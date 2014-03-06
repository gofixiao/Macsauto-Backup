using Macsauto.Domain.SalesModule;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Customer
{
    public class MembershipMap : EntityMap<Membership>
    {
        public MembershipMap()
        {
            Map(x => x.Point);
            Map(x => x.ActiveFrom);
            Map(x => x.ActiveTo);
            Map(x => x.DisactivatedOn);
            Map(x => x.DisactivationReason);
            Map(x => x.ReactivatedOn);
            Map(x => x.ReactivationReason);
        }
    }
}