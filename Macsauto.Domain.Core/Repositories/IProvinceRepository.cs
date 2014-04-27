using System;
using Macsauto.Domain.Core.Entities.Location;

namespace Macsauto.Domain.Core.Repositories
{
    public interface IProvinceRepository : IRepository<Province, Guid>
    {
        Province FindByName(string provinceName);
    }
}