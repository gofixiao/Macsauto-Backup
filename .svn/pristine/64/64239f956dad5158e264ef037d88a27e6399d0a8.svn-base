namespace Macsauto.Domain.SalesModule
{
    using System.Collections.Generic;
    using Macsauto.Domain.Contract;

    public interface IServiceOrderRepository : IRepository<ServiceOrder>
    {
        IList<ServiceOrder> GetAllPendingOrders();
        IList<ServiceOrder> GetOrdersOf(Customer customer);
    }
}