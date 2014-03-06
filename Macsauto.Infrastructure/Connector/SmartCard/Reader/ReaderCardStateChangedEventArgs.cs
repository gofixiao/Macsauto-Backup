namespace Macsauto.Infrastructure.Connector.SmartCard.Reader
{
    using System;

    public class ReaderCardStateChangedEventArgs : EventArgs
    {
        private readonly ReaderCardState _readerCardState;

        public ReaderCardStateChangedEventArgs(ReaderCardState readerCardState)
        {
            _readerCardState = readerCardState;
        }

        public ReaderCardState ReaderCardState { get { return _readerCardState; } }
    }
}