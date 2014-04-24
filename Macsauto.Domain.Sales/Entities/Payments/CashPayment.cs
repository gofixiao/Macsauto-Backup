namespace Macsauto.Domain.Sales.Entities.Payments
{
    public class CashPayment : Payment
    {
        public CashPayment(IChargable chargable, long charged, long paid, long basePoint) : base(chargable, charged, paid, basePoint)
        {
        }

        public override TenderType TenderType
        {
            get { return TenderType.Cash; }
        }
    }
}