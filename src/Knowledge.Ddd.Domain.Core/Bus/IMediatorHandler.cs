using Knowledge.Ddd.Domain.Core.Commands;
using System.Threading.Tasks;

namespace Knowledge.Ddd.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
