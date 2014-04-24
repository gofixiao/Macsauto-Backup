using Macsauto.Domain.BranchManagement.Entities;

namespace Macsauto.Domain.BranchManagement.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User LoginActiveUser(string username, string password);
    }
}
