using FKRM.Domain.Core.Commands;
using MediatR;
using System.Threading.Tasks;

namespace FKRM.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;

        Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
    }
}
