namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Vehicle.VehicleBrand
{
    public class VehicleBrandMap : EntityMap<Domain.SalesModule.VehicleBrand>
    {
        public VehicleBrandMap()
        {
            Map(x => x.Name);
        }
    }
}