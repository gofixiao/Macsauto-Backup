using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.ServiceOrder
{
    using System.Collections.Generic;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class ServiceOrderRepository : NHibernateRepository<ServiceOrder>, IServiceOrderRepository
    {
        private readonly IRepository<ServiceOrder> _repository;
 
        public ServiceOrderRepository(IRepository<ServiceOrder> repository, ITransactionalRepository<ServiceOrder> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public IList<ServiceOrder> GetAllPendingOrders()
        {
            var criteria = DetachedCriteria.For<ServiceOrder>()
                                           .Add(Restrictions.IsNull(@"FinishedOn"));

            return _repository.FindAll(criteria);
        }

        public IList<ServiceOrder> GetOrdersOf(Customer customer)
        {
            var criteria = DetachedCriteria.For<ServiceOrder>()
                                           .Add(Restrictions.Eq(@"Customer", customer));

            return _repository.FindAll(criteria);
        }
    }
}