namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Product
{
    using Macsauto.Domain.SalesModule;

    public class ProductCategoryMap : EntityMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            Table("mai_productcategories");

            References(x => x.ParentCategory)
                .Nullable();
            Map(x => x.Name);
            Map(x => x.Description);
        }
    }
}