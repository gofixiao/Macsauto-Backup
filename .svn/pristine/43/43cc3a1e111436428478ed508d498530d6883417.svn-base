namespace Macsauto.Infrastructure.Connector.SmartCard.Card
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Macsauto.Infrastructure.Connector.SmartCard.Reader;

    public class SmartCard
    {
        private readonly string _type,
                                _rid;
        private byte[] _sentBuff,
                       _recvBuff;
        private int _returnCode,
                    _recvBuffLen;
        private ModWinsCard.SCARD_IO_REQUEST _ioSendRequest;

        public SmartCard(int atrLen, byte[] atr)
        {
            var ridBytes = new byte[] {};

            switch (atrLen)
            {
                case 17:
                    Array.Resize(ref ridBytes, 17);
                    Array.ConstrainedCopy(atr, 4, ridBytes, 0, 17);
                    
                    _rid = GetRID(ridBytes);

                    if (_rid == @"50 12 23 45 56 12 53 54 4E 33 81 C3")
                    {
                        _type = @"ST19XRC8E";
                    }
                    break;
                case 11:
                    Array.Resize(ref ridBytes, 6);
                    Array.ConstrainedCopy(atr, 4, ridBytes, 0, 6);
                    
                    _rid = GetRID(ridBytes);

                    if (_rid == @"06 75 77 81 02 80")
                    {
                        _type = @"Mifare DESFire";
                    }
                    break;
                default:
                    if (atrLen > 14 && atr[12] == 0x03)
                    {
                        Array.Resize(ref ridBytes, 5);
                        Array.ConstrainedCopy(atr, 7, ridBytes, 0, 5);

                        _rid = GetRID(ridBytes);

                        switch (atr[13])
                        {
                            case 0xF0:
                                switch (atr[14])
                                {
                                    case 0x11:
                                        _type = @"FeliCa 212K";
                                        break;
                                    case 0x12:
                                        _type = @"Felica 424K";
                                        break;
                                    case 0x04:
                                        _type = @"Topaz";
                                        break;
                                }
                                break;
                            case 0x00:
                                switch (atr[14])
                                {

                                    case 0x01:
                                        _type = @"Mifare Standard 1K";
                                        break;
                                    case 0x02:
                                        _type = @"Mifare Standard 4K";
                                        break;
                                    case 0x03:
                                        _type = @"Mifare Ultra light";
                                        break;
                                    case 0x04:
                                        _type = @"SLE55R_XXXX";
                                        break;
                                    case 0x06:
                                        _type = @"SR176";
                                        break;
                                    case 0x07:
                                        _type = @"SRI X4K";
                                        break;
                                    case 0x08:
                                        _type = @"AT88RF020";
                                        break;
                                    case 0x09:
                                        _type = @"AT88SC0204CRF";
                                        break;
                                    case 0x0A:
                                        _type = @"AT88SC0808CRF";
                                        break;
                                    case 0x0B:
                                        _type = @"AT88SC1616CRF";
                                        break;
                                    case 0x0C:
                                        _type = @"AT88SC3216CRF";
                                        break;
                                    case 0x0D:
                                        _type = @"AT88SC6416CRF";
                                        break;
                                    case 0x0E:
                                        _type = @"SRF55V10P";
                                        break;
                                    case 0xF:
                                        _type = @"SRF55V02P";
                                        break;
                                    case 0x10:
                                        _type = @"SRF55V10S";
                                        break;
                                    case 0x11:
                                        _type = @"SRF55V02S";
                                        break;
                                    case 0x12:
                                        _type = @"TAG IT";
                                        break;
                                    case 0x13:
                                        _type = @"LRI512";
                                        break;
                                    case 0x14:
                                        _type = @"ICODESLI";
                                        break;
                                    case 0x15:
                                        _type = @"TEMPSENS";
                                        break;
                                    case 0x16:
                                        _type = @"I.CODE1";
                                        break;
                                    case 0x17:
                                        _type = @"PicoPass 2K";
                                        break;
                                    case 0x18:
                                        _type = @"PicoPass 2KS";
                                        break;
                                    case 0x19:
                                        _type = @"PicoPass 16K";
                                        break;
                                    case 0x1A:
                                        _type = @"PicoPass 16KS";
                                        break;
                                    case 0x1B:
                                        _type = @"PicoPass 16K(8x2)";
                                        break;
                                    case 0x1C:
                                        _type = @"PicoPass 16KS(8x2)";
                                        break;
                                    case 0x1D:
                                        _type = @"PicoPass 32KS(16+16)";
                                        break;
                                    case 0x1E:
                                        _type = @"PicoPass 32KS(16+8x2)";
                                        break;
                                    case 0x1F:
                                        _type = @"PicoPass 32KS(8x2+16)";
                                        break;
                                    case 0x20:
                                        _type = @"PicoPass 32KS(8x2+8x2)";
                                        break;
                                    case 0x21:
                                        _type = @"LRI64";
                                        break;
                                    case 0x22:
                                        _type = @"I.CODE UID";
                                        break;
                                    case 0x23:
                                        _type = @"I.CODE EPC";
                                        break;
                                    case 0x24:
                                        _type = @"LRI12";
                                        break;
                                    case 0x25:
                                        _type = @"LRI128";
                                        break;
                                    case 0x26:
                                        _type = @"Mifare Mini";
                                        break;
                                }
                                break;
                        }
                    }
                    break;
            }

            if (string.IsNullOrEmpty(_type)) throw new ApplicationException(@"Cannot determine card type");
        }

        public string Type
        {
            get { return _type; }
        }

        public string RID
        {
            get { return _rid; }
        }

        public string GetBlockValue(int block, int hCard)
        {
            var value = @"";

            _returnCode = AuthenticateBlock(block, hCard);

            if (_returnCode != ModWinsCard.SCARD_S_SUCCESS) throw new ApplicationException(@"Fail to authenticate block", new ApplicationException(ModWinsCard.GetScardErrMsg(_returnCode)));

            _recvBuffLen = _sentBuff[4] + 2;

            _sentBuff = new byte[255];
            _recvBuff = new byte[255];

            _sentBuff = APDUCommands.GetBlockValue(block);
            
            _returnCode = ModWinsCard.SCardTransmit(hCard, ref _ioSendRequest, ref _sentBuff[0], _sentBuff.Length, ref _ioSendRequest, ref _recvBuff[0], ref _recvBuffLen);

            if (_returnCode != ModWinsCard.SCARD_S_SUCCESS) throw new ApplicationException(@"Fail to fetch block value", new ApplicationException(ModWinsCard.GetScardErrMsg(_returnCode)));

            for (int j = 0; j <= _recvBuffLen - 3; j++)
            {
                value += Convert.ToChar(_recvBuff[j]);
            }

            return value;
        }

        public void UpdateBlockValue(int block, string value, int hCard)
        {
            _returnCode = AuthenticateBlock(block, hCard);

            if (_returnCode != ModWinsCard.SCARD_S_SUCCESS) throw new ApplicationException(@"Fail to authenticate block", new ApplicationException(ModWinsCard.GetScardErrMsg(_returnCode)));

            _recvBuffLen = 0x02;

            _sentBuff = new byte[255];
            _recvBuff = new byte[255];

            _sentBuff = APDUCommands.SetBlockValue(block, value);
            
            _returnCode = ModWinsCard.SCardTransmit(hCard, ref _ioSendRequest, ref _sentBuff[0], _sentBuff[4] + 5, ref _ioSendRequest, ref _recvBuff[0], ref _recvBuffLen);

            if (_returnCode != ModWinsCard.SCARD_S_SUCCESS || _recvBuff[0].ToString(@"X2") != @"90" ) throw new ApplicationException(@"Fail to update block value", new ApplicationException(ModWinsCard.GetScardErrMsg(_returnCode)));
        }

        private int AuthenticateBlock(int nBlock, int hCard)
        {
            _ioSendRequest = new ModWinsCard.SCARD_IO_REQUEST { dwProtocol = ModWinsCard.SCARD_PROTOCOL_UNDEFINED, cbPciLength = 8 };

            _recvBuffLen = 0x02;

            _sentBuff = new byte[255];
            _recvBuff = new byte[255];

            _sentBuff = APDUCommands.AuthenticateBlock(nBlock);

            return ModWinsCard.SCardTransmit(hCard, ref _ioSendRequest, ref _sentBuff[0], _sentBuff.Length, ref _ioSendRequest, ref _recvBuff[0], ref _recvBuffLen);
        }

        private static string GetRID(IEnumerable<byte> ridBytes)
        {
            return ridBytes.Aggregate(@"", (current, next) => current + string.Format(@"{0:X2} ", next)).Trim();
        }
    }
}