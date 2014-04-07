using System.Collections.Generic;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain
{
    public interface ICityRepository : IRepository<City>
    {
        City FindByName(string cityName);
        IList<City> GetWhereProvince(Province province);
    }
}