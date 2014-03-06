using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.User
{
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class UserRepository : NHibernateRepository<User>, IUserRepository
    {
        private readonly IRepository<User> _repo;
        private readonly ITransactionalRepository<User> _transactionalRepo;

        public UserRepository(IRepository<User> repo, ITransactionalRepository<User> transactionalRepo) : base(repo, transactionalRepo)
        {
            _repo = repo;
            _transactionalRepo = transactionalRepo;
        }

        public User LoginActiveUser(string username, string password)
        {
            var criteria = DetachedCriteria.For<User>("user")
                        .Add(Restrictions.Eq("Username", username))
                        .Add(Restrictions.Eq("Password", password))
                        .CreateCriteria("user.Employee", "emp");

            return _repo.FindFirst(criteria);
        }
    }
}