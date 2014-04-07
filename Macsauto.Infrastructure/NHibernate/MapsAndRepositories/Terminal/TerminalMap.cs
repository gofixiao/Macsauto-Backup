namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Terminal
{
    public class TerminalMap : EntityMap<Domain.Terminal>
    {
        public TerminalMap()
        {
            Map(x => x.MacAddress);
            References(x => x.Branch);
        }
    }
}