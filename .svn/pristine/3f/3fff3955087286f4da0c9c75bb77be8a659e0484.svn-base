using System.Collections.Generic;

namespace Macsauto.Domain.Shared
{
    using Macsauto.Domain.Contract;

    public interface ICityRepository : IRepository<City>
    {
        City FindByName(string cityName);
        IList<City> GetWhereProvince(Province province);
    }
}