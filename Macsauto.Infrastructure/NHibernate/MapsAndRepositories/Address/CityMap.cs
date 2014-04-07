using Macsauto.Domain;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Address
{
    public class CityMap : EntityMap<City>
    {
        public CityMap()
        {
            Table("mai_cities");

            Id(x => x.Id)
                .GeneratedBy.Increment();
            Map(x => x.Name)
                .UniqueKey("uniqueCity");
            References(x => x.Province)
                .UniqueKey("uniqueCity");

            ReadOnly();
        }
    }
}