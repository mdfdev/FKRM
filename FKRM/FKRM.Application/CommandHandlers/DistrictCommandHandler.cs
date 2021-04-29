using FKRM.Application.Commands.District;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.CommandHandlers
{
    public class DistrictCommandHandler : CommandHandler,
        IRequestHandler<CreateDistrictCommand, Response<int>>,
        IRequestHandler<DeleteDistrictCommand, Response<int>>,
        IRequestHandler<UpdateDistrictCommand, Response<int>>
    {
        private readonly IDistrictRepository _distrciRepository;
        public DistrictCommandHandler(IDistrictRepository districtRepository)
        {
            _distrciRepository = districtRepository;
        }
        public Task<Response<int>> Handle(CreateDistrictCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var district = new Domain.Entities.District()
            {
                Name = request.Name,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _distrciRepository.Add(district);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateDistrictCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _distrciRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                _distrciRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }

        public Task<Response<int>> Handle(DeleteDistrictCommand request, CancellationToken cancellationToken)
        {
            var entity = _distrciRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _distrciRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
