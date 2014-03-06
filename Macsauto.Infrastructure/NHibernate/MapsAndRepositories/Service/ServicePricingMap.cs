namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Service
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class ServicePricingMap : ClassMap<ServicePricing>
    {
        public ServicePricingMap()
        {
            CompositeId()
                .KeyReference(x => x.Service, @"service_id")
                .KeyProperty(x => x.VehicleSize, @"vehicleSize");
            Map(x => x.Price);
        }
    }
}
