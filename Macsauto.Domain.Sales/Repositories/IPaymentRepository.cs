using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        Payment GetPaymentForTransaction(ITransaction transaction);
    }
}