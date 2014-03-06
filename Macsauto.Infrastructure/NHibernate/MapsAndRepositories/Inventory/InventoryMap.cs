namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Inventory
{
    public class InventoryMap : EntityMap<Domain.SalesModule.Inventory>
    {
        public InventoryMap()
        {
            Table("mai_inventories");

            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.BuyPrice);
            References(x => x.UoM);
        }
    }
}
