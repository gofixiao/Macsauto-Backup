namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Service
{
    using Macsauto.Domain.SalesModule;

    public class ServiceMap : EntityMap<Service>
    {
        public ServiceMap()
        {
            Map(x => x.Name);
            Map(x => x.Description);
            References(x => x.Category);
            HasMany(x => x.ServicePrices);
        }
    }
}