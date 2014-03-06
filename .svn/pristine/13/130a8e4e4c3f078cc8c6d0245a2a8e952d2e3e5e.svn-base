namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.PointRedemption
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class PointRedemptionItemMap : ClassMap<PointRedemptionItem>
    {
        public PointRedemptionItemMap()
        {
            CompositeId()
                .KeyReference(x => x.Merchandise, @"merchandise_id")
                .KeyReference(x => x.PointRedemption, @"pointRedemption_id");
            Map(x => x.Quantity);
        }
    }
}