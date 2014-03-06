namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Product
{
    using Macsauto.Domain.SalesModule;

    public class ProductMap : EntityMap<Product>
    {
        public ProductMap()
        {
            References(x => x.Inventory);
            References(x => x.Category);
            Map(x => x.Volume);
            Map(x => x.SellPrice);
            Map(x => x.Name);
            Map(x => x.Description);
        }
    }
}
