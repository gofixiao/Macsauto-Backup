using Macsauto.Domain.Contract;

namespace Macsauto.Domain
{
    public interface IBranchRepository : IRepository<Branch>
    {
        long GetLastIndex();
    }
}