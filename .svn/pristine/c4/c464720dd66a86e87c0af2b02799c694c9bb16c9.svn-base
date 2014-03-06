namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Contract;

    public class CashPayment : Payment
    {
        protected CashPayment()
        {
        }

        public CashPayment(ITransaction transaction, long charged, long paid, long basePoint) : base(transaction, charged, paid, basePoint)
        {
        }

        public override TenderType TenderType
        {
            get { return TenderType.CASH; }
        }
    }
}