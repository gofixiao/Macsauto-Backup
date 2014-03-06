using System.Collections.Generic;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Address
{
    using Macsauto.Domain.Shared;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class CityRepository : NHibernateRepository<City>, ICityRepository
    {
        private readonly IRepository<City> _repo; 
        private readonly ITransactionalRepository<City> _transactionalRepo;
 
        public CityRepository(
            IRepository<City> repo, 
            ITransactionalRepository<City> transactionalRepo) 
            : base(repo, transactionalRepo)
        {
            _repo = repo;
            _transactionalRepo = transactionalRepo;
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
