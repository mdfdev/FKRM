using FKRM.Domain.Commands.Area;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class AreaCommandHandler : CommandHandler,
        IRequestHandler<CreateAreaCommand, Response<int>>,
        IRequestHandler<DeleteAreaCommand, Response<int>>,
        IRequestHandler<UpdateAreaCommand, Response<int>>
    {
        private readonly IAreaRepository _areaRepository;
        public AreaCommandHandler(IAreaRepository areaRepository)
        {
            _areaRepository = areaRepository;
        }
        public Task<Response<int>> Handle(CreateAreaCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var area = new Entities.Area()
            {
                Name = request.Name,
                BranchId =  request.BranchId ,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _areaRepository.Add(area);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteAreaCommand request, CancellationToken cancellationToken)
        {
            var entity = _areaRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            _areaRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateAreaCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _areaRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.BranchId = request.BranchId;
                entity.ModifiedDate = request.ModifiedDate;
                _areaRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
