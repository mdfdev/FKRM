using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Commands;
using FKRM.Domain.Core.Events;
using FKRM.Domain.Core.Wrappers;
using MediatR;
using System.Threading.Tasks;

namespace FKRM.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IEventStoreService _eventStoreService;

        public InMemoryBus(IMediator mediator, IEventStoreService eventStoreService)
        {
            _mediator = mediator;
            _eventStoreService = eventStoreService;
        }
        public Task SendCommand<T>(T command) where T : Command
        {
            return  _mediator.Send(command);
        }
        public Task RaiseEvent<T>(T @event) where T : Event
        {
            if (!@event.MessageType.Equals("DomainNotification"))
                _eventStoreService?.Save(@event);
            return _mediator.Publish(@event);
        }
    }
}
