using FKRM.Domain.Commands.MarkingType;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class MarkingTypeCommandHandler : CommandHandler,
        IRequestHandler<CreateMarkingTypeCommand, Response<int>>,
        IRequestHandler<DeleteMarkingTypeCommand, Response<int>>,
        IRequestHandler<UpdateMarkingTypeCommand, Response<int>>
    {
        private readonly IMarkingTypeRepository _markingTypeRepository;
        public MarkingTypeCommandHandler(IMarkingTypeRepository MarkingTypeRepository)
        {
            _markingTypeRepository = MarkingTypeRepository;
        }
        public Task<Response<int>> Handle(CreateMarkingTypeCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var MarkingType = new Entities.MarkingType()
            {
                Name = request.Name,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _markingTypeRepository.Add(MarkingType);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteMarkingTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = _markingTypeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _markingTypeRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateMarkingTypeCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _markingTypeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                _markingTypeRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
