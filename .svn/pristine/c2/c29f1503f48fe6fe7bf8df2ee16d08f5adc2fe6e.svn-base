using Macsauto.Infrastructure.NHibernate.Contract;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Service
{
    using Macsauto.Domain.SalesModule;

    public class ServiceRepository : NHibernateRepository<Service>, IServiceRepository
    {
        public ServiceRepository(IRepository<Service> repository, ITransactionalRepository<Service> transactionalRepository) : base(repository, transactionalRepository)
        {
        }
    }
}
