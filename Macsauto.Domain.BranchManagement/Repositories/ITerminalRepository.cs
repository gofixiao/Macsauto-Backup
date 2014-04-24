using Macsauto.Domain.BranchManagement.Entities;

namespace Macsauto.Domain.BranchManagement.Repositories
{
    public interface ITerminalRepository : IRepository<Terminal>
    {
        Terminal FindByMac(string macAddress);
    }
}