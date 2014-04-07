using System.Collections.Generic;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IVehicleModelRepository : IRepository<VehicleModel>
    {
        IList<VehicleModel> GetAllInBrand(VehicleBrand brand);
    }
}