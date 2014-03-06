namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Payment
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class DebitCardPaymentMap : SubclassMap<DebitCardPayment>
    {
        public DebitCardPaymentMap()
        {
            DiscriminatorValue(TenderType.DEBITCARD);

            References(x => x.CardIssuer);
            Map(x => x.CardNumber);
        }
    }
}