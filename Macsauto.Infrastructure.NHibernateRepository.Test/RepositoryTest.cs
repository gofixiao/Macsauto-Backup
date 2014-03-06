using NHibernate;

namespace Macsauto.Infrastructure.NHibernateRepository.Test
{
    using System;

    using Macsauto.Domain.Model.Common;
    using Macsauto.Domain.Model.Employee;
    using Macsauto.Domain.Model.User;
    using Macsauto.Infrastructure.NHibernate.Common;
    using Macsauto.Infrastructure.NHibernate.Repositories.Employee;
    using Macsauto.Infrastructure.NHibernate.Repositories.User;

    using NHibernate;

    using NUnit.Framework;

    [TestFixture]
    public class RepositoryTest
    {
        private IEmployeeRepository _employeeRepository;
        private IUserRepository _userRepository;
        private ISession _session;

        [Test]
        public void CanInsertEmployee()
        {
            using (_session = NHibernateSessionManager.GetSession())
            {
                _employeeRepository = new EmployeeRepository(
                    new Repository<Employee>(_session)
                );

                _userRepository = new UserRepository(
                    new Repository<User>(_session)
                );

                using (var transaction = _session.BeginTransaction())
                {
                    var john = new Employee()
                    {
                        FirstName = "Johny",
                        LastName = "Doe",
                        BirthDate = new DateTime(1989, 12, 08),
                        Gender = Gender.Male,
                        HomeAddress = new Address("California", "90210", "Chill Rd.")
                    };

                    var johnAsUser = new User("mynameisjohnymamba", "mypassword", john);

                    var newEmployee = _employeeRepository.RegisterEmployee(john);
                    var newUser = _userRepository.CreateUser(johnAsUser);

                    transaction.Commit();
                }}
        }

        [Test]
        [TransactionScope]
        public void CanUseTransactionAttribute()
        {
            _employeeRepository = new EmployeeRepository(
                    new Repository<Employee>(NHibernateSessionManager.GetSession())
                );

            var john = new Employee()
            {
                FirstName = "Johny",
                LastName = "Doe",
                BirthDate = new DateTime(1989, 12, 08),
                Gender = Gender.Male,
                HomeAddress = new Address("California", "90210", "Chill Rd.")
            };

            var newEmployee = _employeeRepository.RegisterEmployee(john);
        }
    }
}
