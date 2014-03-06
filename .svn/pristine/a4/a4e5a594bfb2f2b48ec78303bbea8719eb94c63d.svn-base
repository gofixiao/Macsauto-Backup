using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Inventory
{
    using System.Collections.Generic;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class StorageRepository : NHibernateRepository<Storage>, IStorageRepository
    {
        private readonly IRepository<Storage> _repository;

        public StorageRepository(IRepository<Storage> repository, ITransactionalRepository<Storage> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public IList<Storage> GetStoragesWithInventory(Inventory inventory)
        {
            var criteria = DetachedCriteria.For<Storage>()
                                           .CreateCriteria(@"StoredInventories", @"storedInventory")
                                           .Add(Restrictions.Eq(@"storedInventory.Inventory.Id", inventory.Id));

            return _repository.FindAll(criteria);
        }
    }
}