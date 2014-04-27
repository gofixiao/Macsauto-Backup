using System.Collections.Generic;
using Macsauto.Domain.Core.Entities.Location;

namespace Macsauto.Domain.Core.Repositories
{
    public interface ICityRepository : IRepository<City>
    {
        City FindByName(string cityName);
        IList<City> GetWhereProvince(Province province);
    }
}