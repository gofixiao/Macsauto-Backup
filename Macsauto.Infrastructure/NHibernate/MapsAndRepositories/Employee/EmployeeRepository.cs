using System.Collections.Generic;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Employee
{
    using System;
    using Macsauto.Domain.UserManagementModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class EmployeeRepository : NHibernateRepository<Employee>, IEmployeeRepository
    {
        private readonly IRepository<Employee> _repo;
        private readonly ITransactionalRepository<Employee> _transactionalRepo; 

        public EmployeeRepository(IRepository<Employee> repo, ITransactionalRepository<Employee> transactionalRepo) : base(repo, transactionalRepo)
        {
            _repo = repo;
            _transactionalRepo = transactionalRepo;
        }

        public Employee GetEmployeeByName(string name)
        {
            var criteria = DetachedCriteria.For<Employee>()
                                           .Add(
                                                Restrictions.Disjunction()
                                                .Add(Restrictions.InsensitiveLike("Firstname", name, MatchMode.Anywhere))
                                                .Add(Restrictions.InsensitiveLike("Middlename", name, MatchMode.Anywhere))
                                                .Add(Restrictions.InsensitiveLike("Lastname", name, MatchMode.Anywhere))
                                           );

            return _repo.FindFirst(criteria);
        }

        public Employee Register(Employee employee)
        {
            return _transactionalRepo.Save(employee);
        }

        public IList<Employee> GetAllInBranch(Branch branch)
        {
            var criteria = DetachedCriteria.For<Employee>()
                                           .Add(Restrictions.Eq(@"Branch", branch));

            return _repo.FindAll(criteria);
        }
    }
}