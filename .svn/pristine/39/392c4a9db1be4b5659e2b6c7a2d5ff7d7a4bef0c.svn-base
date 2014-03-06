using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Customer
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;
    
    public class CustomerRepository : NHibernateRepository<Customer>, ICustomerRepository
    {
        private readonly IRepository<Customer> _repo;

        public CustomerRepository(IRepository<Customer> repo, ITransactionalRepository<Customer> transactionalRepo) : base(repo, transactionalRepo)
        {
            _repo = repo;
        }
        
        public Customer GetByVehicle(string licenseNumber)
        {
            var criteria = DetachedCriteria.For<Customer>()
                                           .CreateCriteria(@"VehicleRegistrations")
                                           .CreateCriteria(@"RegisteredVehicle")
                                           .Add(Restrictions.Eq(@"Id", licenseNumber));

            return _repo.FindFirst(criteria);
        }

        public Customer GetByMembershipCode(string membershipCode)
        {
            var criteria = DetachedCriteria.For<Customer>()
                                           .CreateCriteria(@"Membership")
                                           .Add(Restrictions.Eq(@"Code", membershipCode));

            return _repo.FindFirst(criteria);
        }
    }
}