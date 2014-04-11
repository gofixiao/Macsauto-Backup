using System.Collections.Generic;
using Macsauto.Domain.Contract;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IServiceOrderRepository : IRepository<ServiceOrder>
    {
        IList<ServiceOrder> GetAllPendingOrders();
        IList<ServiceOrder> GetOrdersOf(Customer customer);
    }
}