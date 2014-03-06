namespace Macsauto.Domain.UserManagementModule
{
    using Macsauto.Domain.Contract;

    public interface IBranchRepository : IRepository<Branch>
    {
        long GetLastIndex();
    }
}