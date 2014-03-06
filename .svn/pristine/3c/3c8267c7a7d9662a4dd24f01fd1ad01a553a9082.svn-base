namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Address
{
    using Macsauto.Domain.Shared;

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