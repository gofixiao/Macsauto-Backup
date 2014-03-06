namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.PointRedemption
{
    using Macsauto.Domain.SalesModule;

    public class PointRedemptionMap : EntityMap<PointRedemption>
    {
        public PointRedemptionMap()
        {
            References(x => x.Customer);
            HasMany(x => x.PointRedemptionItems);
        }
    }
}