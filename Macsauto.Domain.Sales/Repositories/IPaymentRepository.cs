using Macsauto.Domain.Contract;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        Payment GetPaymentFor(IChargableTransaction chargable);
    }
}