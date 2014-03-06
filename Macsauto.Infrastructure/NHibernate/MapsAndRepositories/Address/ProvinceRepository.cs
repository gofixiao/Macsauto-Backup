using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Address
{
    using Macsauto.Domain.Shared;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class ProvinceRepository : NHibernateRepository<Province>, IProvinceRepository
    {
        private readonly IRepository<Province> _repo;
        private readonly ITransactionalRepository<Province> _transactionalRepo;

        public ProvinceRepository(
            IRepository<Province> repo, 
            ITransactionalRepository<Province> transactionalRepo)
            : base(repo, transactionalRepo)
        {
            _repo = repo;
            _transactionalRepo = transactionalRepo;
        }

        public Province FindByName(string provinceName)
        {
            var criteria = DetachedCriteria.For<Province>()
                                           .Add(Restrictions.Eq("Name", provinceName));

            return _repo.FindFirst(criteria);
        }
    }
}