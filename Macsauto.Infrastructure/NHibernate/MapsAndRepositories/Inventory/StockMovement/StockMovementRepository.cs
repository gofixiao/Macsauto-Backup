using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Inventory
{
    using System.Collections.Generic;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class StockMovementRepository : NHibernateRepository<StockMovement>, IStockMovementRepository
    {
        private readonly IRepository<StockMovement> _repository;

        public StockMovementRepository(IRepository<StockMovement> repository, ITransactionalRepository<StockMovement> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public IList<StockMovement> GetMovementsWithInventory(Inventory inventory)
        {
            var criteria = DetachedCriteria.For<StockMovement>()
                                           .CreateCriteria(@"StockMovementItems", @"Item")
                                           .Add(Restrictions.Eq(@"Item.Inventory", inventory));
            Order[] orders =
            {
                Order.Asc(@"CreatedOn")
            };

            return _repository.FindAll(criteria, orders);
        }
    }
}