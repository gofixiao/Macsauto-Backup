using Macsauto.Domain;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Address
{
    public class ProvinceMap : EntityMap<Province>
    {
        public ProvinceMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Increment();
            Map(x => x.Name)
                .Unique();

            ReadOnly();
        }
    }
}