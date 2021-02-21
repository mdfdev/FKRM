using FKRM.Domain.Core.Commands;
using FKRM.Domain.Core.Events;
using System.Threading.Tasks;

namespace FKRM.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
