namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Vehicle.VehicleModel
{
    using Macsauto.Domain.SalesModule;

    public class VehicleModelMap : EntityMap<VehicleModel>
    {
        public VehicleModelMap()
        {
            Map(x => x.Name);
            References(x => x.Brand);
            Map(x => x.Size);
            Map(x => x.Type);
        }
    }
}