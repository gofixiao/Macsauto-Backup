using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales
{
    public interface IChargableTransaction
    {
        Customer TransactionCustomer { get; }
        string TransactionCode { get; }
        string TransactionName { get; }
        double TotalCharge { get; };
    }
}