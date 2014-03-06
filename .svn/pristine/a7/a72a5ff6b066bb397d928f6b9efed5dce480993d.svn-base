using Macsauto.Domain.UserManagementModule;
using Macsauto.Infrastructure.NHibernate.Contract;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Branch
{
    public class BranchRepository : NHibernateRepository<Domain.UserManagementModule.Branch>, IBranchRepository
    {
        private readonly IRepository<Domain.UserManagementModule.Branch> _repo;
        private readonly ITransactionalRepository<Domain.UserManagementModule.Branch> _transactionalRepo; 

        public BranchRepository(IRepository<Domain.UserManagementModule.Branch> repo, ITransactionalRepository<Domain.UserManagementModule.Branch> transactionalRepo) : base(repo, transactionalRepo)
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
