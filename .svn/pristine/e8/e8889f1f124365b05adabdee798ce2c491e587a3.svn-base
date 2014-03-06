using Macsauto.Infrastructure.NHibernate.Contract;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Inventory
{
    using Macsauto.Domain.SalesModule;

    public class InventoryRepository : NHibernateRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(IRepository<Inventory> repository, ITransactionalRepository<Inventory> transactionalRepository) : base(repository, transactionalRepository)
        {
        }
    }
}