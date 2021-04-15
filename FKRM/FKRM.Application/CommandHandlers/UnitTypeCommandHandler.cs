using FKRM.Application.Commands.UnitType;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.CommandHandlers
{
    public class UnitTypeCommandHandler : CommandHandler,
        IRequestHandler<CreateUnitTypeCommand, Response<int>>,
        IRequestHandler<DeleteUnitTypeCommand, Response<int>>,
        IRequestHandler<UpdateUnitTypeCommand, Response<int>>
    {
        private readonly IUnitTypeRepository _unitTypeRepository;
        public UnitTypeCommandHandler(IUnitTypeRepository unitTypeRepository)
        {
            _unitTypeRepository = unitTypeRepository;
        }
        public Task<Response<int>> Handle(CreateUnitTypeCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var unitType = new Domain.Entities.UnitType()
            {
                Name = request.Name,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
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
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _unitTypeRepository.GetById(request.ID);
            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                _unitTypeRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
