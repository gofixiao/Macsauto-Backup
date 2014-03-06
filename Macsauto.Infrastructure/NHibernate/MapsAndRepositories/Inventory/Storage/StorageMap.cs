namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Inventory
{
    using Macsauto.Domain.SalesModule;

    public class StorageMap : EntityMap<Storage>
    {
        public StorageMap()
        {
            Map(x => x.Name);
            Map(x => x.Description);
            HasMany(x => x.StoredInventories);
        }
    }
}
