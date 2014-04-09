using System.Collections.Generic;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IStockMovementRepository : IRepository<StockMovement>
    {
        IList<StockMovement> GetMovementsWithInventory(Inventory inventory);
    }
}