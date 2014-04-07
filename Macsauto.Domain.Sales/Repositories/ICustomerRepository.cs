using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByVehicle(string licenseNumber);
        Customer GetByMembershipCode(string membershipCode);
    }
}