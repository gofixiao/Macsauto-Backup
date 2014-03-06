namespace Macsauto.Domain.SalesModule
{
    using System.Collections.Generic;
    using Macsauto.Domain.Contract;

    public interface IServiceBookingRepository : IRepository<ServiceBooking>
    {
        IList<ServiceBooking> GetAllPendingBookings();
        IList<ServiceBooking> GetBookingsOf(Customer customer);
    }
}