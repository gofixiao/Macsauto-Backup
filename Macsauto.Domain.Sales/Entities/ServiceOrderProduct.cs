namespace Macsauto.Domain.Sales.Entities
{
    public class ServiceOrderProduct : ValueObject<ServiceOrderProduct>
    {
        private ServiceOrder _serviceOrder;
        private Product _product;
        private long _quantity;
        private long _price;
        private long _currentPrice;

        protected ServiceOrderProduct()
        {
        }

        public ServiceOrderProduct(ServiceOrder serviceOrder, Product product, long quantity, long price)
        {
            _serviceOrder = serviceOrder;
            _product = product;
            _quantity = quantity;
            _price = price;
            _currentPrice = product.SellPrice;
        }

        public virtual ServiceOrder ServiceOrder
        {
            get { return _serviceOrder; }
            protected set { _serviceOrder = value; }
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

        public virtual long Discount
        {
            get { return _currentPrice - _price; }
        }
    }
}