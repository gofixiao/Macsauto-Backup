namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.PurchaseOrder
{
    using Macsauto.Domain.SalesModule;

    public class PurchaseOrderMap : EntityMap<PurchaseOrder>
    {
        public PurchaseOrderMap()
        {
            References(x => x.Customer)
                .Nullable();
            HasMany(x => x.PurchaseOrderItems);
        }
    }
}