using Macsauto.Domain.SalesModule;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Product
{
    public class UnitOfMeasurementMap : EntityMap<UnitOfMeasurement>
    {
        public UnitOfMeasurementMap()
        {
            Map(x => x.Description);
        }
    }
}
