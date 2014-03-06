namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.ServiceOrder
{
    using Macsauto.Domain.SalesModule;

    public class ServiceOrderMap : EntityMap<ServiceOrder>
    {
        public ServiceOrderMap()
        {
            References(x => x.ServiceBooking)
                .Nullable();
            References(x => x.Customer);
            References(x => x.VehicleRegistration);
            Map(x => x.FinishedOn)
                .Nullable();
            Map(x => x.AdditionalInformation);
            HasMany(x => x.ServiceOrderItems);
            HasMany(x => x.ServiceOrderProduct);
        }
    }
}