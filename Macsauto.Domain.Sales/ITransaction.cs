using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales
{

    public interface ITransaction
    {
        string GetTransactionId();
        string GetTransactionType();
        long GetTotalCharged();
        Customer GetCustomer();
    }
}