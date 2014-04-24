namespace Macsauto.Domain.BranchManagement.Repositories
{
    public interface IBranchRepository : IRepository<Branch>
    {
        long GetLastIndex();
    }
}