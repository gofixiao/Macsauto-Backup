namespace Macsauto.Domain.Sales.Entities.Payments
{
    public class CreditCardPayment : Payment
    {
        private CreditCardType _creditCardType;
        private CardIssuer _cardIssuer;
        private string _cardNumber;

        public CreditCardPayment(IChargable chargable, long charged, CreditCardType creditCardType, string cardNumber, CardIssuer cardIssuer, long basePoint) : base(chargable, charged, charged, basePoint)
        {
            _creditCardType = creditCardType;
            _cardIssuer = cardIssuer;
            _cardNumber = cardNumber;
        }

        public virtual CreditCardType CreditCardType
        {
            get { return _creditCardType; }
            protected set { _creditCardType = value; }
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
            get { return TenderType.CreditCard; }
        }
    }

    public enum CreditCardType
    {
        Original,
        MasterCard,
        Visa
    }
}