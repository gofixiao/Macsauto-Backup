namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Product
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class ProductRepository : NHibernateRepository<Product>, IProductRepository
    {
        public ProductRepository(IRepository<Product> repository, ITransactionalRepository<Product> transactionalRepository) : base(repository, transactionalRepository)
        {
        }
    }
}