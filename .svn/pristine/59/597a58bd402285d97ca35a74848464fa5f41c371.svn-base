namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Branch
{
    public class BranchMap : EntityMap<Domain.UserManagementModule.Branch>
    {
        public BranchMap()
        {
            Table("mai_branches");

            Map(x => x.Name);
            Component(x => x.Address, m =>
            {
                m.References(x => x.City);
                m.Map(x => x.Zipcode);
                m.Map(x => x.AddressLine);
            });
        }
    }
}