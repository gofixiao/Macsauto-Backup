using System.Collections.Generic;
using Macsauto.Domain.Contract;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IPointRedemptionRepository : IRepository<PointRedemption>
    {
        IList<PointRedemption> GetRedemptionsOf(Customer customer);
    }
}