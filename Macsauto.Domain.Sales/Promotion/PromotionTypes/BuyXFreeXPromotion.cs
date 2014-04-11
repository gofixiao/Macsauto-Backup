using System.Collections.Generic;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Promotion.PromotionTypes
{
    public class AmountOff : ProductDiscount
    {
        private long _amount;

        public AmountOff(long amount, IList<Product> applicableProducts, IList<Condition> conditions,
                         IList<Customer> applicableCustomers = null)
            : base(applicableProducts, conditions, applicableCustomers)
        {
            _amount = amount;
        }

        public virtual long Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}