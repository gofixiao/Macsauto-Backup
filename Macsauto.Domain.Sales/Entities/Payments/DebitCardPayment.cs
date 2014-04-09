namespace Macsauto.Domain.Sales.Entities.Payments
{
    public class DebitCardPayment : Payment
    {
        private CardIssuer _cardIssuer;
        private string _cardNumber;

        protected DebitCardPayment()
        {
        }

        public DebitCardPayment(ITransaction transaction, long charged, CardIssuer cardIssuer, string cardNumber, long basePoint) : base(transaction, charged, charged, basePoint)
        {
            _cardIssuer = cardIssuer;
            _cardNumber = cardNumber;
        }

        public virtual CardIssuer CardIssuer
        {
            get { return _cardIssuer; }
            protected set { _cardIssuer = value; }
        }

        public virtual string CardNumber
        {
            get { return _cardNumber; }
            protected set { _cardNumber = value; }
        }

        public override TenderType TenderType
        {
            get { return TenderType.DebitCard; }
        }
    }
}