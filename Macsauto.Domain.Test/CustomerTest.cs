namespace Macsauto.Domain.Test
{
    using NUnit.Framework;

    using ObjectDumper;

    using Macsauto.Domain.SalesModule;

    [TestFixture]
    public class CustomerTest
    {
        private Customer _customer;
        private DebugWriter _writer;
        
        [SetUp]
        public void SetUp()
        {
            _customer = new Customer("123", new PersonName("Samuel"), "021");
            _writer = new DebugWriter();
        }

        [Test]
        public void CanCreateCustomer()
        {
            Assert.NotNull(_customer);
        }

        [Test]
        public void CanUpgradeCustomerToMember()
        {
            var membershipRegistration = _customer.RegisterAsMember();

            Assert.True(_customer.IsInActiveMembership);
            Assert.NotNull(membershipRegistration);

            _customer.Dump("customer");
        }

        [Test]
        public void CanDisactivateMembership()
        {
            CanUpgradeCustomerToMember();

            _customer.Membership.Disactivate("UGLY");

            Assert.False(_customer.IsInActiveMembership);

            _customer.Dump("customer");
        }
    }
}
