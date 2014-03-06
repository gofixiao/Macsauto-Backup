using System.Collections.Generic;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain.SalesModule
{
    public interface IStorageRepository : IRepository<Storage>
    {
        IList<Storage> GetStoragesWithInventory(Inventory inventory);
    }
}