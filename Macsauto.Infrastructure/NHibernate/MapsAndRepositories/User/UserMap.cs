namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.User
{
    public class UserMap : EntityMap<Domain.User>
    {
        public UserMap()
        {
            References(x => x.Employee)
                .Unique();
            Map(x => x.Username)
                .Index(@"IK_username");
            Map(x => x.Password);
        }
    }
}