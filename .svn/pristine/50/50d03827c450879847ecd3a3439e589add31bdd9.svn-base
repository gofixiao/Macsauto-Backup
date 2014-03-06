namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Merchandise
{
    using Macsauto.Domain.SalesModule;

    public class MerchandiseMap : EntityMap<Merchandise>
    {
        public MerchandiseMap()
        {
            References(x => x.Inventory);
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.PointCost);
            Map(x => x.Volume);
        }
    }
}
