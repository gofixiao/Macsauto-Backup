namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Payment
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class CreditCardPaymentMap : SubclassMap<CreditCardPayment>
    {
        public CreditCardPaymentMap()
        {
            DiscriminatorValue(TenderType.DEBITCARD);

            References(x => x.CardIssuer);
            Map(x => x.CreditCardType);
            Map(x => x.CardNumber);
        }
    }
}