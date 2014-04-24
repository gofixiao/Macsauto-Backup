using Macsauto.Domain.Core.Entities.Location;

namespace Macsauto.Domain.Core.Repositories
{
    public interface IProvinceRepository : IRepository<Province>
    {
        Province FindByName(string provinceName);
    }
}