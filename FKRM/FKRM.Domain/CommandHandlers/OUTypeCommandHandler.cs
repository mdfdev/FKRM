using FKRM.Domain.Commands.OUType;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    class OUTypeCommandHandler : CommandHandler,
        IRequestHandler<CreateOUTypeCommand, Response<int>>,
        IRequestHandler<DeleteOUTypeCommand, Response<int>>,
        IRequestHandler<UpdateOUTypeCommand, Response<int>>
    {
        private readonly IOUTypeRepository _oUTypeRepository;
        public OUTypeCommandHandler(IOUTypeRepository OUTypeRepository, IMediatorHandler bus) : base(bus)
        {
            _oUTypeRepository = OUTypeRepository;
        }
        public Task<Response<int>> Handle(CreateOUTypeCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(new Response<int>(400));
            }
            var OUType = new Entities.OUType()
            {
                Name = request.Name
            };
            _oUTypeRepository.Add(OUType);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteOUTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = _oUTypeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _oUTypeRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateOUTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = _oUTypeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _oUTypeRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
