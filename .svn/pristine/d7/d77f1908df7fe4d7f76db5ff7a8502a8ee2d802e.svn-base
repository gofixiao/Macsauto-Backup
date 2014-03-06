namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.PurchaseOrder
{
    using FluentNHibernate.Mapping;
    using Macsauto.Domain.SalesModule;

    public class PurchaseOrderItemMap : ClassMap<PurchaseOrderItem>
    {
        public PurchaseOrderItemMap()
        {
            CompositeId()
                .KeyReference(x => x.PurchaseOrder, @"purchaseOrder_id")
                .KeyReference(x => x.Product, @"product_id");
            Map(x => x.Price);
            Map(x => x.CurrentPrice);
            Map(x => x.Quantity);
        }
    }
}