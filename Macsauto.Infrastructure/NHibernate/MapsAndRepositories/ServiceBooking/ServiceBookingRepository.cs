using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.ServiceBooking
{
    using System.Collections.Generic;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class ServiceBookingRepository : NHibernateRepository<ServiceBooking>, IServiceBookingRepository
    {
        private readonly IRepository<ServiceBooking> _repository;

        public ServiceBookingRepository(IRepository<ServiceBooking> repository, ITransactionalRepository<ServiceBooking> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public IList<ServiceBooking> GetAllPendingBookings()
        {
            var criteria = DetachedCriteria.For<ServiceBooking>()
                                           .Add(Restrictions.IsNull(@"CheckedOutOn"));

            return _repository.FindAll(criteria);
        }

        public IList<ServiceBooking> GetBookingsOf(Customer customer)
        {
            var criteria = DetachedCriteria.For<ServiceBooking>()
                                           .Add(Restrictions.Eq(@"Customer", customer));

            return _repository.FindAll(criteria);
        }
    }
}