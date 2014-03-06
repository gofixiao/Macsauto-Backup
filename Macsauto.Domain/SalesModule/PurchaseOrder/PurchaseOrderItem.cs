namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Shared;

    public class PurchaseOrderItem : ValueObject<PurchaseOrderItem>
    {
        private PurchaseOrder _purchaseOrder;
        private Product _product;
        private long _quantity;
        private long _price;
        private long _currentPrice;

        protected PurchaseOrderItem()
        {
        }

        public PurchaseOrderItem(PurchaseOrder purchaseOrder, Product product, long quantity, long price)
        {
            _purchaseOrder = purchaseOrder;
            _product = product;
            _quantity = quantity;
            _price = price;
            _currentPrice = _product.SellPrice;
        }

        public virtual PurchaseOrder PurchaseOrder
        {
            get { return _purchaseOrder; }
            protected set { _purchaseOrder = value; }
        }

        public virtual Product Product
        {
            get { return _product; }
            protected set { _product = value; }
        }

        public virtual long Quantity
        {
            get { return _quantity; }
            protected set { _quantity = value; }
        }

        public virtual long Price
        {
            get { return _price; }
            protected set { _price = value; }
        }

        public virtual long CurrentPrice
        {
            get { return _currentPrice; }
            protected set { _currentPrice = value; }
        }
    }
}