using Macsauto.Domain.Contract;

namespace Macsauto.Domain.UserManagementModule
{
    public interface ITerminalRepository : IRepository<Terminal>
    {
        Terminal FindByMac(string macAddress);
    }
}