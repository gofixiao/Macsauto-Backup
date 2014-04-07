using System.Collections.Generic;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IStorageRepository : IRepository<Storage>
    {
        IList<Storage> GetStoragesWithInventory(Inventory inventory);
    }
}