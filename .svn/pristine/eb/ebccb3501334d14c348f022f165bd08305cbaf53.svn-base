namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Payment
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class CashPaymentMap : SubclassMap<CashPayment>
    {
        public CashPaymentMap()
        {
            DiscriminatorValue(TenderType.CASH);
        }
    }
}