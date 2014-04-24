using System.Collections.Generic;

namespace Macsauto.Domain.Core.Location.City
{
    public interface ICityRepository : IRepository<City>
    {
        City FindByName(string cityName);
        IList<City> GetWhereProvince(Province.Province province);
    }
}