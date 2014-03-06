namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Payment
{
    using Macsauto.Domain.SalesModule;

    public class PaymentMap : EntityMap<Payment>
    {
        public PaymentMap()
        {
            Map(x => x.TransactionCode);
            Map(x => x.Charged);
            Map(x => x.Paid);
            Map(x => x.PaymentChange);

            DiscriminateSubClassesOnColumn(@"TenderType");
        }
    }
}