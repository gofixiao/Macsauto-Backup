namespace Macsauto.Infrastructure.Connector.SmartCard.Reader
{
    using System;
    using System.Text;
    using System.Windows.Forms;
    using Macsauto.Infrastructure.Connector.SmartCard.Card;

    public class SmartCardReader : IDisposable
    {
        private readonly Timer _pollingTimer;
        private readonly string _name;
        private readonly int _hContext,
                             _dwControlCode;

        private ReaderCardState _readerCardState = ReaderCardState.NO_CARD_DETECTED;
        private static SmartCard _smartCard;

        private byte[] _sentBuffer,
                       _receivedBuffer;
        private int _hCard,
                    _protocol,
                    _returnCode;

        public event EventHandler<ReaderCardStateChangedEventArgs> ReaderCardStateChanged;

        public SmartCardReader(string name, int hContext)
        {
            _name = name;
            _hContext = hContext;
            _dwControlCode = (int) ModWinsCard.IOCTL_CCID_ESCAPE_SCARD_CTL_CODE;

            IsConnected = false;
            IsControlled = false;

            _pollingTimer = new Timer();
            _pollingTimer.Tick += _pollingTimer_Tick;

            PiccParams = new PICCParams()
                .DetectFeliCa212KCard()
                .DetectFeliCa424KCard()
                .DetectISO14443TypeACard()
                .DetectISO14443TypeBCard()
                .DetectTopazCard()
                .EnableAutomaticATSGeneration()
                .EnableAutomaticPICCPolling()
                .SetPollInterval250();
        }

        public string Name { get { return _name; } }
        public string Firmware
        {
            get
            {
                _sentBuffer = APDUCommands.GetFirmware();
                _receivedBuffer = new byte[10];
                _receivedBuffer[0] = 0;

                return CanControl()
                    ? Encoding.ASCII.GetString(_receivedBuffer, 0, _receivedBuffer.Length)
                    : @"";
            }
        }
        public bool IsConnected { get; private set; }
        public bool IsControlled { get; private set; }
        public ReaderCardState ReaderCardState { get { return _readerCardState; } }
        public SmartCard SmartCard { get { return _smartCard; } }
        public PICCParams PiccParams { get; set; }

        public void StartPolling(int interval)
        {
            _pollingTimer.Interval = interval;
            _pollingTimer.Start();
        }

        public void StopPolling()
        {
            _pollingTimer.Stop();
        }

        public string GetCardBlockValue(int block)
        {
            Connect();

            if (_smartCard == null) throw new ApplicationException(@"No card detected");

            return _smartCard.GetBlockValue(block, _hCard);
        }

        public void UpdateCardBlockValue(int block, string value)
        {
            Connect();

            if (_smartCard == null) throw new ApplicationException(@"No card detected");

            _smartCard.UpdateBlockValue(block, value, _hCard);
        }

        private bool CanControl()
        {
            var bytesReturned = 0;

            if (!IsConnected) Connect();

            _sentBuffer = APDUCommands.GetControl();
            _receivedBuffer = new byte[21];
            _receivedBuffer[0] = 0;

            IsControlled = ModWinsCard.SCardControl(
                _hCard, 
                _dwControlCode, 
                ref _sentBuffer[0], 
                _sentBuffer.Length, 
                ref _receivedBuffer[0], 
                _receivedBuffer.Length, 
                ref bytesReturned) == ModWinsCard.SCARD_S_SUCCESS;

            return IsControlled;
        }

        private void Connect()
        {
            if (IsConnected)
            {
                _returnCode = ModWinsCard.SCardDisconnect(_hCard, ModWinsCard.SCARD_EJECT_CARD);

                IsConnected = false;
            }

            //_returnCode = APDUCommands.SetPICCParams(_piccParams);
            _returnCode = ModWinsCard.SCardConnect(_hContext, _name, ModWinsCard.SCARD_SHARE_SHARED, ModWinsCard.SCARD_PROTOCOL_T0 | ModWinsCard.SCARD_PROTOCOL_T1, ref _hCard, ref _protocol);

            if (_returnCode != ModWinsCard.SCARD_S_SUCCESS)
            {
                _returnCode = ModWinsCard.SCardConnect(_hContext, _name, ModWinsCard.SCARD_SHARE_DIRECT, ModWinsCard.SCARD_PROTOCOL_UNDEFINED, ref _hCard, ref _protocol);

                if (_returnCode != ModWinsCard.SCARD_S_SUCCESS)
                {
                    throw new ApplicationException(@"Failed to connect to reader " + _name, new ApplicationException(ModWinsCard.GetScardErrMsg(_returnCode)));
                }
            }

            IsConnected = true;
        }

        private void _pollingTimer_Tick(object sender, EventArgs e)
        {
            int readerLen = 0, 
                dwState = 0, 
                dwProtocol = 0;

            _receivedBuffer = new byte[32];

            var atrLen = _receivedBuffer.Length;

            Connect();

            _returnCode = ModWinsCard.SCardStatus(_hCard, _name, ref readerLen, ref dwState, ref dwProtocol, ref _receivedBuffer[0], ref atrLen);

            if (_returnCode != ModWinsCard.SCARD_S_SUCCESS && ShouldChangeState(ReaderCardState.NO_CARD_DETECTED))
            {
                _smartCard = null;

                OnReaderCardStateChanged(new ReaderCardStateChangedEventArgs(ReaderCardState.NO_CARD_DETECTED));
            }
            else
            {
                try
                {
                    var card = new SmartCard(atrLen, _receivedBuffer);

                    if (ShouldChangeState(ReaderCardState.CARD_PRESENT) || card.Type != _smartCard.Type)
                    {
                        if (_smartCard == null)
                        {
                            _smartCard = card;
                        }
                        else
                        {
                            _smartCard = _smartCard.Type == card.Type ? _smartCard : card;
                        }

                        OnReaderCardStateChanged(new ReaderCardStateChangedEventArgs(ReaderCardState.CARD_PRESENT));
                    }
                }
                catch (Exception)
                {
                    _smartCard = null;

                    OnReaderCardStateChanged(new ReaderCardStateChangedEventArgs(ReaderCardState.NO_CARD_DETECTED));
                }
            }
        }

        private bool ShouldChangeState(ReaderCardState readerCardState)
        {
            return _readerCardState != readerCardState;
        }

        protected virtual void OnReaderCardStateChanged(ReaderCardStateChangedEventArgs e)
        {
            _readerCardState = e.ReaderCardState;

            var handler = ReaderCardStateChanged;
            if (handler != null) handler(this, e);
        }

        public void Dispose()
        {
            ModWinsCard.SCardEndTransaction(_hCard, ModWinsCard.SCARD_EJECT_CARD);
            ModWinsCard.SCardReleaseContext(_hContext);
            ModWinsCard.SCardDisconnect(_hCard, ModWinsCard.SCARD_EJECT_CARD);
        }
    }
}