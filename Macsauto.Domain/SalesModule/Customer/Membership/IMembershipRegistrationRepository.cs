namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Contract;

    public interface IMembershipRegistrationRepository : IRepository<MembershipRegistration>
    {
        MembershipRegistration GetRegistrationOf(Customer customer);
    }
}