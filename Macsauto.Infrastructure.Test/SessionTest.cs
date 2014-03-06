using System.Collections.Generic;
using Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Service;
using NHibernate;

namespace Macsauto.Infrastructure.Test
{
    using System;
    using Crosscutting.Transaction;
    using NHibernate;
    using NHibernate.Common;
    using Domain.SalesModule;
    using Domain.Shared;
    using Domain.UserManagementModule;
    using NHibernate.MapsAndRepositories.Customer;
    using NHibernate.MapsAndRepositories.Employee;
    using NHibernate.MapsAndRepositories.User;
    using NHibernate.MapsAndRepositories.Vehicle;
    using NUnit.Framework;

    [TestFixture]
    public class SessionTest
    {
        private IEmployeeRepository _employeeRepository;
        private IUserRepository _userRepository;
        private ICustomerRepository _customerRepository;
        private IServiceRepository _serviceRepository;

        [SetUp]
        public void SetUp()
        {
            _employeeRepository = new EmployeeRepository(
                new Repository<Employee>(NHibernateSessionManager.GetLocalSession()),
                new TransactionalRepository<Employee>(
                    NHibernateSessionManager.GetLocalSession()));
            _userRepository = new UserRepository(
                new Repository<User>(NHibernateSessionManager.GetLocalSession()),
                new TransactionalRepository<User>(
                    NHibernateSessionManager.GetLocalSession()));
            _customerRepository = new CustomerRepository(
                new Repository<Customer>(NHibernateSessionManager.GetLocalSession()),
                new TransactionalRepository<Customer>(
                    NHibernateSessionManager.GetLocalSession()));
            _serviceRepository = new ServiceRepository(
                new Repository<Service>(NHibernateSessionManager.GetLocalSession()),
                new TransactionalRepository<Service>(
                    NHibernateSessionManager.GetLocalSession()));
        }

        [Test]
        public void CanCreateSession()
        {
            Assert.NotNull(NHibernateSessionManager.GetLocalSession());
        }

        [Test]
        public void CanGetService()
        {
            var services = _serviceRepository.GetAll();
        }

        [Test]
        public void CanAddUser()
        {

            //using (ITransaction tx = NHibernateSessionManager.GetLocalSession().BeginTransaction())
            //{
            //    var employee = new Employee(new Branch(@"MACSAUTO JAKARTA", new Address())
            //        , "Samuel"
            //        , Gender.Male);

            //    employee = _employeeRepository.Insert(employee);

            //    var user = new User(employee, "samuel", "123");

            //    user = _userRepository.Insert(user);

            //    tx.Commit();

            //    Assert.NotNull(user);
            //}
        }

        [Test]
        public void CanAddContinuously()
        {
            using (var session = NHibernateSessionManager.GetLocalSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var brand = new VehicleBrand("BRND", "new");

                    session.Save(brand);

                    tx.Commit();
                }

                using (var tx = session.BeginTransaction())
                {
                    var brand = new VehicleBrand("BRNDA", "new");

                    session.Save(brand);

                    tx.Commit();
                }
            }
        }

        [Test]
        public void CanAddVehicleToCustomer()
        {
            using (ITransaction tx = NHibernateSessionManager.GetLocalSession().BeginTransaction())
            {
                var customer = new Customer("321", new PersonName("Orang", "Percobaan", "Aja"), "012312313");

                //customer.AddVehicleRegistration(new VehicleRegistration
                //    {
                //        ExpiryDate = DateTime.Now.AddYears(5),
                //        RegisteredVehicle = new Car(@"B123DS", new VehicleSpecification
                //            {
                //                Brand = "Daihatsu",
                //                Model = "Xenia",
                //                Size = VehicleSize.Medium
                //            }, @"BIRU"),
                //        RegisteredTo = customer
                //    });

                _customerRepository.Insert(customer);

                tx.Commit();
            }

            NHibernateSessionManager.GetLocalSession().Flush();
        }

        [Test]
        public void CanRegisterMember()
        {
            //using (var tx = NHibernateSessionManager.GetLocalSession().BeginTransaction())
            //{
            //    var customer = new Customer()
            //        {
            //            Firstname = "John",
            //            Lastname = "Doe",
            //        };

            //    customer = _customerRepository.Insert(customer);

            //    var member = new Member(customer);

            //    member = _memberRepository.Insert(member);

            //    tx.Commit();

            //    Assert.NotNull(member);
            //}
        }

        [Test]
        public void SaveToRegisterMember()
        {
        //    var customerRepo = new CustomerRepository(
        //        new Repository<Customer>(NHibernateSessionManager.GetLocalSession()),
        //        new TransactionalRepository<Customer>(
        //            NHibernateSessionManager.GetLocalSession()));

        //    using (ITransaction tx = NHibernateSessionManager.GetLocalSession().BeginTransaction())
        //    {
        //        Customer customer = customerRepo.GetCustomerByVehicle("B123DS");

        //        MembershipRegistration member = customer.RegisterAsMember();

        //        tx.Commit();

        //        Assert.NotNull(member);
        //    }
        }

        [Test]
        public void CanGetCustomer()
        {
            IList<Customer> customers = _customerRepository.GetAll();

            Assert.NotNull(customers);
        }

        [Test]
        public void AddNewUser()
        {
            ISession session = NHibernateSessionManager.GetLocalSession();

            //session.DoTransactional(sess =>
            //    {
            //        var branch = new Branch
            //            {
            //                Name = "MACSAUTO",
            //                BranchCode = "MAI",
            //                BranchId = "001",
            //                City = "Jakarta"
            //            };

            //        sess.Save(branch);

            //        var employee = new Employee(branch, "SAMUEL", Gender.Male);

            //        sess.Save(employee);

            //        var user = new User(employee, "SAMUEL", "123");

            //        sess.Save(employee);
            //    });
        }
    }
}