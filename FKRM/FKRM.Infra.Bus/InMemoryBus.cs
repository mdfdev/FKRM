using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Commands;
using FKRM.Domain.Core.Wrappers;
using MediatR;
using System.Threading.Tasks;

namespace FKRM.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task SendCommand<T>(T command) where T : Command
        {
            return  _mediator.Send(command);
        }
    }
}
