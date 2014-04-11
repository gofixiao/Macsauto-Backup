using Macsauto.Domain.Contract;
using Macsauto.Domain.Sales.Entities;

namespace Macsauto.Domain.Sales.Repositories
{
    public interface IMembershipRegistrationRepository : IRepository<MembershipRegistration>
    {
        MembershipRegistration GetRegistrationOf(Customer customer);
    }
}