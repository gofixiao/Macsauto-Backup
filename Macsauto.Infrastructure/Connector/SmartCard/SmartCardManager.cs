namespace Macsauto.Infrastructure.Connector.SmartCard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Macsauto.Infrastructure.Connector.SmartCard.Reader;

    public class CardManager
    {
        private static int _returnCode,
                           _hContext;

        private static IList<SmartCardReader> _cardReaders;

        public static void Initialize()
        {
            if (_cardReaders == null || _cardReaders.Count == 0)
            {
                _cardReaders = new List<SmartCardReader>();
                _returnCode = ModWinsCard.SCardEstablishContext(ModWinsCard.SCARD_SCOPE_USER, 0, 0, ref _hContext);

                if (_returnCode != ModWinsCard.SCARD_S_SUCCESS)
                {
                    throw new ApplicationException(GetMessage());
                }

                FetchReaders();
            }
        }

        public static IList<SmartCardReader> CardReaders
        {
            get { return _cardReaders; }
        }

        private static void FetchReaders()
        {
            var pcchReader = 0;

            _returnCode = ModWinsCard.SCardListReaders(_hContext, null, null, ref pcchReader);

            if (_returnCode != ModWinsCard.SCARD_S_SUCCESS)
            {
                throw new ApplicationException(GetMessage());
            }

            var readerNameBytes = new byte[pcchReader];

            _returnCode = ModWinsCard.SCardListReaders(_hContext, null, readerNameBytes, ref pcchReader);

            if (_returnCode != ModWinsCard.SCARD_S_SUCCESS)
            {
                throw new ApplicationException(GetMessage());
            }

            var readerName = readerNameBytes.Where(readerNameByte => (char)readerNameByte != 0)
                                            .Aggregate(@"", (current, readerNameByte) => current + (char)readerNameByte);

            _cardReaders.Add(new SmartCardReader(readerName, _hContext));
        }

        private static string GetMessage()
        {
            var message = ModWinsCard.GetScardErrMsg(_returnCode);

            return message == @"?" ? (@"An error occured : " + _returnCode) : message;
        }
    }
}