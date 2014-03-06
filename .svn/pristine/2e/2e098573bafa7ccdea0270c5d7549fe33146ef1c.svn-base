using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.PurchaseOrder
{
    using System.Collections.Generic;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class PurchaseOrderRepository : NHibernateRepository<PurchaseOrder>, IPurchaseOrderRepository
    {
        private readonly IRepository<PurchaseOrder> _repository;

        public PurchaseOrderRepository(IRepository<PurchaseOrder> repository, ITransactionalRepository<PurchaseOrder> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public IList<PurchaseOrder> GetPurchasesOf(Customer customer)
        {
            var criteria = DetachedCriteria.For<PurchaseOrder>()
                                           .Add(Restrictions.Eq(@"Customer", customer));

            return _repository.FindAll(criteria);
        }
    }
}