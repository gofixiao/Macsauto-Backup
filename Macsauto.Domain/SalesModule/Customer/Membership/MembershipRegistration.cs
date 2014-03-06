namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Shared;

    public class MembershipRegistration : Entity
    {
        private Customer _customer;

        protected MembershipRegistration()
        {
        }

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