using System.Collections.Generic;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IPurchaseOrderRepository : IRepository<PurchaseOrder>
    {
        IList<PurchaseOrder> GetPurchasesOf(Customer customer);        
    }
}