namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Inventory
{
    using Macsauto.Domain.SalesModule;

    public class StockMovementMap : EntityMap<StockMovement>
    {
        public StockMovementMap()
        {
            Map(x => x.Type);
            Map(x => x.Reference);
            Map(x => x.Remark);
            HasMany(x => x.StockMovementItems);
        }
    }
}