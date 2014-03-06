namespace Macsauto.Domain.SalesModule
{
    using System.Collections.Generic;
    using Macsauto.Domain.Contract;

    public interface IStockMovementRepository : IRepository<StockMovement>
    {
        IList<StockMovement> GetMovementsWithInventory(Inventory inventory);
    }
}