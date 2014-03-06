namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.ServiceOrder
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class ServiceOrderProductMap : ClassMap<ServiceOrderProduct>
    {
        public ServiceOrderProductMap()
        {
            CompositeId()
                .KeyReference(x => x.Product, @"product_id")
                .KeyReference(x => x.ServiceOrder, @"serviceOrder_id");
            Map(x => x.Price);
            Map(x => x.Quantity);
            Map(x => x.CurrentPrice);
        }
    }
}