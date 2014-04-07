using Macsauto.Domain;
using Macsauto.Infrastructure.NHibernate.Contract;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Branch
{
    public class BranchRepository : NHibernateRepository<Domain.Branch>, IBranchRepository
    {
        private readonly IRepository<Domain.Branch> _repo;
        private readonly ITransactionalRepository<Domain.Branch> _transactionalRepo; 

        public BranchRepository(IRepository<Domain.Branch> repo, ITransactionalRepository<Domain.Branch> transactionalRepo) : base(repo, transactionalRepo)
        {
            _repo = repo;
            _transactionalRepo = transactionalRepo;
        }

        public long GetLastIndex()
        {
            return _repo.Count();
        }
    }
}
