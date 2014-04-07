using Macsauto.Domain;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Terminal
{
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class TerminalRepository : NHibernateRepository<Domain.Terminal>, ITerminalRepository
    {
        private readonly IRepository<Domain.Terminal> _repository;
 
        public TerminalRepository(IRepository<Domain.Terminal> repository, ITransactionalRepository<Domain.Terminal> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public Domain.Terminal FindByMac(string macAddress)
        {
            var criteria = DetachedCriteria.For<Domain.Terminal>()
                                           .Add(Restrictions.Eq(@"MacAddress", macAddress));

            return _repository.FindFirst(criteria);
        }
    }
}