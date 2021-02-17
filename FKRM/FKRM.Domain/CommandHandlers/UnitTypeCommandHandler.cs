using FKRM.Domain.Commands.UnitType;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class UnitTypeCommandHandler : CommandHandler,
        IRequestHandler<CreateUnitTypeCommand, Response<int>>,
        IRequestHandler<DeleteUnitTypeCommand, Response<int>>,
        IRequestHandler<UpdateUnitTypeCommand, Response<int>>
    {
        private readonly IUnitTypeRepository _unitTypeRepository;
        public UnitTypeCommandHandler(IUnitTypeRepository unitTypeRepository, IMediatorHandler bus) : base(bus)
        {
            _unitTypeRepository = unitTypeRepository;
        }
        public Task<Response<int>> Handle(CreateUnitTypeCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(new Response<int>(400));
            }
            var unitType = new Entities.UnitType()
            {
                Name = request.Name
            };
            _unitTypeRepository.Add(unitType);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteUnitTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = _unitTypeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _unitTypeRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateUnitTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = _unitTypeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _unitTypeRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
