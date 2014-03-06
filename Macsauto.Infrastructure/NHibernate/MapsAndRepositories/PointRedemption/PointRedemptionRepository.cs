using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.PointRedemption
{
    using System.Collections.Generic;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class PointRedemptionRepository : NHibernateRepository<PointRedemption>, IPointRedemptionRepository
    {
        private readonly IRepository<PointRedemption> _repository;

        public PointRedemptionRepository(IRepository<PointRedemption> repository, ITransactionalRepository<PointRedemption> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public IList<PointRedemption> GetRedemptionsOf(Customer customer)
        {
            var criteria = DetachedCriteria.For<PointRedemption>()
                                           .Add(Restrictions.Eq(@"Customer", customer));

            return _repository.FindAll(criteria);
        }
    }
}