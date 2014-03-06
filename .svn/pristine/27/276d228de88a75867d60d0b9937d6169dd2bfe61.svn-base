namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Product
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class ProductCategoryRepository : NHibernateRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IRepository<ProductCategory> repository, ITransactionalRepository<ProductCategory> transactionalRepository) : base(repository, transactionalRepository)
        {
        }
    }
}