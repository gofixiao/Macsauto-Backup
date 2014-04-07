using Macsauto.Domain.Contract;

namespace Macsauto.Domain
{
    public interface ITerminalRepository : IRepository<Terminal>
    {
        Terminal FindByMac(string macAddress);
    }
}