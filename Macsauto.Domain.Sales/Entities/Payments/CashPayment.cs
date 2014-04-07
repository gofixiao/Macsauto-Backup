namespace Macsauto.Domain.Sales.Entities.Payments
{
    public class CashPayment : Payment
    {
        public CashPayment(ITransaction transaction, long charged, long paid, long basePoint) : base(transaction, charged, paid, basePoint)
        {
        }

        public override TenderType TenderType
        {
            get { return TenderType.Cash; }
        }
    }
}