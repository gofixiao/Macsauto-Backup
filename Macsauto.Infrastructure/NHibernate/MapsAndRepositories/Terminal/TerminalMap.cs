namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Terminal
{
    using Macsauto.Domain.UserManagementModule;

    public class TerminalMap : EntityMap<Terminal>
    {
        public TerminalMap()
        {
            Map(x => x.MacAddress);
            References(x => x.Branch);
        }
    }
}