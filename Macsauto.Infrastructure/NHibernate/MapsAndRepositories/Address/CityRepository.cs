using System.Collections.Generic;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Address
{
    using Macsauto.Domain.Shared;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class CityRepository : NHibernateRepository<City>, ICityRepository
    {
        private readonly IRepository<City> _repo; 
 
        public CityRepository(IRepository<City> repo) : base(repo)
        {
            _repo = repo;
        }

        public City FindByName(string cityName)
        {
            var criteria = DetachedCriteria.For<City>()
                                           .Add(Restrictions.Eq("Name", cityName));

            return _repo.FindFirst(criteria);
        }

        public IList<City> GetWhereProvince(Province province)
        {
            var criteria = DetachedCriteria.For<City>()
                                           .Add(Restrictions.Eq("Province", province));

            return _repo.FindAll(criteria);
        }
    }
}
