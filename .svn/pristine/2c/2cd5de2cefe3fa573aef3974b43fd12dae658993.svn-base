using Macsauto.Infrastructure.NHibernate.Contract;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Service
{
    using Macsauto.Domain.SalesModule;

    public class ServiceCategoryRepository : NHibernateRepository<ServiceCategory>, IServiceCategoryRepository
    {
        public ServiceCategoryRepository(IRepository<ServiceCategory> repository, ITransactionalRepository<ServiceCategory> transactionalRepository) : base(repository, transactionalRepository)
        {
        }
    }
}