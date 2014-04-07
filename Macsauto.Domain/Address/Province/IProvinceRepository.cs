using Macsauto.Domain.Contract;

namespace Macsauto.Domain
{
    public interface IProvinceRepository : IRepository<Province>
    {
        Province FindByName(string provinceName);
    }
}