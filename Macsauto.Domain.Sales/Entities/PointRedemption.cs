using System;
using System.Collections.Generic;

namespace Macsauto.Domain.Sales.PointRedemption
{
    public class PointRedemption : Entity, IAutoGenerateCode
    {
        private Customer.Customer _customer;
        private IList<PointRedemptionItem> _pointRedemptionItems;
        private string _remark;

        protected PointRedemption()
        {
        }

        public PointRedemption(Customer.Customer customer)
        {
            if (!customer.IsInActiveMembership)
            {
                throw new ApplicationException(@"Customer is not in active membership");
            }

            _customer = customer;
            _pointRedemptionItems = new List<PointRedemptionItem>();
        }

        public PointRedemption(Customer.Customer customer, string remark)
        {
            if (!customer.IsInActiveMembership)
            {
                throw new ApplicationException(@"Customer is not in active membership");
            }

            _customer = customer;
            _remark = remark;
            _pointRedemptionItems = new List<PointRedemptionItem>();
        }

        public virtual Customer.Customer Customer
        {
            get { return _customer; }
            protected set { _customer = value; }
        }

        public virtual IList<PointRedemptionItem> PointRedemptionItems
        {
            get { return _pointRedemptionItems; }
            protected set { _pointRedemptionItems = value; }
        }

        public virtual string Remark
        {
            get { return _remark; }
            protected set { _remark = value; }
        }

        public virtual void AddRedemptionItem(Merchandise.Merchandise merchandise, long quantity)
        {
            _pointRedemptionItems.Add(new PointRedemptionItem(this, merchandise, quantity));
        }
    }
}