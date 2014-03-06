namespace Macsauto.Domain.SalesModule.Promotion
{
    using System.Collections.Generic;

    public abstract class ProductDiscount : Promotion
    {
        private IList<Product> _applicableProducts;


        protected ProductDiscount(IList<Product> applicableProducts, 
                                  IList<Condition> conditions,
                                  IList<Customer> applicableCustomers = null)
        {
            _applicableProducts = applicableProducts;
        }

        public virtual IList<Product> ApplicableProducts
        {
            get { return _applicableProducts; }
            set { _applicableProducts = value; }
        }
    }
}