using System.Collections.Generic;

namespace Macsauto.Domain.Sales.Inventory.StockMovement
{
    public interface IStockMovementRepository : IRepository<StockMovement>
    {
        IList<StockMovement> GetMovementsWithInventory(Inventory inventory);
    }
}