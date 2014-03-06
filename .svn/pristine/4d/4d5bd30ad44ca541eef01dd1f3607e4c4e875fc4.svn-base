namespace Macsauto.Domain.SalesModule
{
    using Macsauto.Domain.Contract;

    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByVehicle(string licenseNumber);
        Customer GetByMembershipCode(string membershipCode);
    }
}