namespace Macsauto.Domain.SalesModule
{
    using System.Collections.Generic;
    using Macsauto.Domain.Shared;

    public class PurchaseOrder : Entity
    {
        private Customer _customer;
        private IList<PurchaseOrderItem> _purchaseOrderItems;

        public PurchaseOrder()
        {
            _purchaseOrderItems = new List<PurchaseOrderItem>();
        }

        public PurchaseOrder(Customer customer)
        {
            _customer = customer;
            _purchaseOrderItems = new List<PurchaseOrderItem>();
        }

        public virtual Customer Customer
        {
            get { return _customer; }
            protected set { _customer = value; }
        }

        public virtual IList<PurchaseOrderItem> PurchaseOrderItems
        {
            get { return _purchaseOrderItems; }
            protected set { _purchaseOrderItems = value; }
        }
    }
}
