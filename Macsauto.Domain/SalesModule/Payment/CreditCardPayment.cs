﻿namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Contract;

    public class CreditCardPayment : Payment
    {
        private CreditCardType _creditCardType;
        private CardIssuer _cardIssuer;
        private string _cardNumber;

        protected CreditCardPayment()
        {
        }

        public CreditCardPayment(ITransaction transaction, long charged, CreditCardType creditCardType, string cardNumber, CardIssuer cardIssuer, long basePoint) : base(transaction, charged, charged, basePoint)
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
            get { return TenderType.CREDITCARD; }
        }
    }

    public enum CreditCardType
    {
// ReSharper disable InconsistentNaming
        ORIGINAL,
        MASTERCARD,
        VISA
// ReSharper restore InconsistentNaming
    }
}