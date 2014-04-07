using System.Collections.Generic;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IServiceBookingRepository : IRepository<ServiceBooking>
    {
        IList<ServiceBooking> GetAllPendingBookings();
        IList<ServiceBooking> GetBookingsOf(Customer customer);
    }
}