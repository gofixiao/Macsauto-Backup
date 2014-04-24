using System;

namespace Macsauto.Domain.Sales.Entities
{
    public abstract class Payment : Entity
    {
        private long _charged;
        private long _paid;
        private long _change;
        private long _basePoint;
        private string _transactionCode;
        private string _transactionType;

        protected Payment(IChargable chargable, long charged, long paid, long basePoint)
        {
            var customer = chargable.GetCustomer();

            _transactionCode = chargable.GetTransactionId();
            _transactionType = chargable.GetTransactionType();
            _charged = charged;
            _paid = paid;
            _change = _paid - _charged <= 0 ? 0 : _paid - _charged;
            _basePoint = basePoint;

            if (customer.IsInActiveMembership)
            {
                var totalPointsEarned = Math.Floor((double)charged / _basePoint);

                customer.Membership.AddPoint((long)totalPointsEarned);
            }
        }

        public virtual string TransactionCode
        {
            get { return _transactionCode; }
            set { _transactionCode = value; }
        }

        public virtual long Charged
        {
            get { return _charged; }
            protected set { _charged = value; }
        }

        public virtual long Paid
        {
            get { return _paid; }
            protected set { _paid = value; }
        }

        public virtual long PaymentChange
        {
            get { return _change; }
            protected set { _change = value; }
        }

        public virtual long BasePoint
        {
            get { return _basePoint; }
            protected set { _basePoint = value; }
        }

        public virtual string TransactionType
        {
            get { return _transactionType; }
            protected set { _transactionType = value; }
        }

        public abstract TenderType TenderType { get; }
    }
}