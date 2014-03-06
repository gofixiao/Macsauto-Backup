namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.User
{
    using Macsauto.Domain.UserManagementModule;

    public class UserMap : EntityMap<User>
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