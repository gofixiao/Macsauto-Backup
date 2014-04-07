using System.Collections.Generic;
using Macsauto.Domain;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Employee
{
    using System;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class EmployeeRepository : NHibernateRepository<Domain.Employee>, IEmployeeRepository
    {
        private readonly IRepository<Domain.Employee> _repo;
        private readonly ITransactionalRepository<Domain.Employee> _transactionalRepo; 

        public EmployeeRepository(IRepository<Domain.Employee> repo, ITransactionalRepository<Domain.Employee> transactionalRepo) : base(repo, transactionalRepo)
        {
            _repo = repo;
            _transactionalRepo = transactionalRepo;
        }

        public Domain.Employee GetEmployeeByName(string name)
        {
            var criteria = DetachedCriteria.For<Domain.Employee>()
                                           .Add(
                                                Restrictions.Disjunction()
                                                .Add(Restrictions.InsensitiveLike("Firstname", name, MatchMode.Anywhere))
                                                .Add(Restrictions.InsensitiveLike("Middlename", name, MatchMode.Anywhere))
                                                .Add(Restrictions.InsensitiveLike("Lastname", name, MatchMode.Anywhere))
                                           );

            return _repo.FindFirst(criteria);
        }

        public Domain.Employee Register(Domain.Employee employee)
        {
            return _transactionalRepo.Save(employee);
        }

        public IList<Domain.Employee> GetAllInBranch(Domain.Branch branch)
        {
            var criteria = DetachedCriteria.For<Domain.Employee>()
                                           .Add(Restrictions.Eq(@"Branch", branch));

            return _repo.FindAll(criteria);
        }
    }
}