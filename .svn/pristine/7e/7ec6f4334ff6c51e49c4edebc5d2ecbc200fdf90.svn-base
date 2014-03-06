namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.ServiceBooking
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class ServiceBookingItemMap : ClassMap<ServiceBookingItem>
    {
        public ServiceBookingItemMap()
        {
            CompositeId()
                .KeyReference(x => x.ServiceBooking, @"serviceBooking_id")
                .KeyReference(x => x.Service, @"service_id");
            Map(x => x.Price);
            Map(x => x.CurrentPrice);
        }
    }
}