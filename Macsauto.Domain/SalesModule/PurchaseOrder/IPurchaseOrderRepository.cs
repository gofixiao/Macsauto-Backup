namespace Macsauto.Domain.SalesModule
{
    using System.Collections.Generic;
    using Macsauto.Domain.Contract;

    public interface IPurchaseOrderRepository : IRepository<PurchaseOrder>
    {
        IList<PurchaseOrder> GetPurchasesOf(Customer customer);        
    }
}