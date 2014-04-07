using System;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Shared;

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

        public override string GenerateNewCode<T>(IRepository<T> repository)
        {
            return string.Format(@"MREG/{0:yyMMdd}/{1:0000}/{2:0000}",
                DateTime.Now,
                repository.GetLastDailyIndex());
        }
    }
}