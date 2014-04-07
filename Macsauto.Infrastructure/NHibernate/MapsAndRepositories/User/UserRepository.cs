using Macsauto.Domain;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.User
{
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class UserRepository : NHibernateRepository<Domain.User>, IUserRepository
    {
        private readonly IRepository<Domain.User> _repo;
        private readonly ITransactionalRepository<Domain.User> _transactionalRepo;

        public UserRepository(IRepository<Domain.User> repo, ITransactionalRepository<Domain.User> transactionalRepo) : base(repo, transactionalRepo)
        {
            _repo = repo;
            _transactionalRepo = transactionalRepo;
        }

        public Domain.User LoginActiveUser(string username, string password)
        {
            var criteria = DetachedCriteria.For<Domain.User>("user")
                        .Add(Restrictions.Eq("Username", username))
                        .Add(Restrictions.Eq("Password", password))
                        .CreateCriteria("user.Employee", "emp");

            return _repo.FindFirst(criteria);
        }
    }
}