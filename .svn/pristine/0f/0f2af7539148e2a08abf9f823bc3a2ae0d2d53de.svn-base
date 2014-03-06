namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.ServiceBooking
{
    using Macsauto.Domain.SalesModule;

    public class ServiceBookingMap : EntityMap<ServiceBooking>
    {
        public ServiceBookingMap()
        {
            References(x => x.Customer);
            References(x => x.VehicleRegistration);
            Map(x => x.DueDate);
            Map(x => x.CheckedOutOn)
                .Nullable();
            HasMany(x => x.ServiceBookingItems);
        }
    }
}