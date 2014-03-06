namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Inventory
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class StockMovementItemMap : ClassMap<StockMovementItem>
    {
        public StockMovementItemMap()
        {
            CompositeId()
                .KeyReference(x => x.StockMovement, @"stockMovement_id")
                .KeyReference(x => x.Inventory, @"inventory_id");
            References(x => x.Storage);
            Map(x => x.Quantity);
            Map(x => x.PreviousStock);
            Map(x => x.CurrentStock);
        }
    }
}