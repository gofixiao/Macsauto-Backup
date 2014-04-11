using System;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain.Sales.Entities
{
    public class MembershipRegistration : Entity
    {
        private Customer _customer;

        public MembershipRegistration(Customer customer)
        {
            _customer = customer;
        }

        public virtual Customer Customer
        {
            get { return _customer; }
            protected set { _customer = value; }
        }
    }
}