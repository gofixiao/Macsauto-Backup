namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Service
{
    using Macsauto.Domain.SalesModule;

    public class ServiceCategoryMap : EntityMap<ServiceCategory>
    {
        public ServiceCategoryMap()
        {
            Table(@"mai_servicecategories");

            Map(x => x.Name);
            Map(x => x.Description);
            References(x => x.ParentCategory);
        }
    }
}
