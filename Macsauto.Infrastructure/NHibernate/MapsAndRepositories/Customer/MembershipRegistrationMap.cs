using Macsauto.Domain.SalesModule;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Customer
{
    public class MembershipRegistrationMap : EntityMap<MembershipRegistration>
    {
        public MembershipRegistrationMap()
        {
            References(x => x.Customer);
        }
    }
}
