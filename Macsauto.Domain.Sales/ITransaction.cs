using Macsauto.Domain.Sales.Customer;

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