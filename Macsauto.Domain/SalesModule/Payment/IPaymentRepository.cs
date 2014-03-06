namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Contract;

    public interface IPaymentRepository : IRepository<Payment>
    {
        Payment GetPaymentForTransaction(ITransaction transaction);
    }
}