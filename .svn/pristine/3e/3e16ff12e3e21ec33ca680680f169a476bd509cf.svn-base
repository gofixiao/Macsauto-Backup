using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Terminal
{
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class TerminalRepository : NHibernateRepository<Terminal>, ITerminalRepository
    {
        private readonly IRepository<Terminal> _repository;
 
        public TerminalRepository(IRepository<Terminal> repository, ITransactionalRepository<Terminal> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public Terminal FindByMac(string macAddress)
        {
            var criteria = DetachedCriteria.For<Terminal>()
                                           .Add(Restrictions.Eq(@"MacAddress", macAddress));

            return _repository.FindFirst(criteria);
        }
    }
}