using Macsauto.Domain.SalesModule;
using FluentNHibernate.Mapping;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Vehicle
{
    public class VehicleRegistrationMap : EntityMap<VehicleRegistration>
    {
        public VehicleRegistrationMap()
        {
            References(x => x.RegisteredTo, "registeredTo_id");
            References(x => x.RegisteredVehicle);
            Map(x => x.ExpiryDate);
        }
    }
}
