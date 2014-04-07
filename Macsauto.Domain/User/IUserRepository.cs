using Macsauto.Domain.Contract;

namespace Macsauto.Domain
{
    public interface IUserRepository : IRepository<User>
    {
        User LoginActiveUser(string username, string password);
    }
}
