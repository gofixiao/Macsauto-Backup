namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.ServiceOrder
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class ServiceOrderItemMap : ClassMap<ServiceOrderItem>
    {
        public ServiceOrderItemMap()
        {
            CompositeId()
                .KeyReference(x => x.ServiceOrder, @"serviceOrder_id")
                .KeyReference(x => x.Service, @"service_id");
            Map(x => x.Price);
            Map(x => x.CurrentPrice);
            Map(x => x.VoidOn)
                .Nullable();
            Map(x => x.VoidReason);
            References(x => x.VoidBy)
                .Nullable();
        }
    }
}