namespace Macsauto.Domain.Contract
{
    using Macsauto.Domain.SalesModule;

    public interface ITransaction
    {
        string GetTransactionId();
        string GetTransactionType();
        long GetTotalCharged();
        Customer GetCustomer();
    }
}