using FluentNHibernate.Mapping;
using Macsauto.Domain.SalesModule;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Inventory
{
    public class StoredInventoryMap : ClassMap<StoredInventory>
    {
        public StoredInventoryMap()
        {
            Table("mai_storedinventories");

            Id()
                .GeneratedBy.Identity();
            Map(x => x.Stock);
            References(x => x.Inventory);
            References(x => x.Storage);
        }
    }
}