using FKRM.Application.Commands.Feature;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.CommandHandlers
{
    public class FeatureCommandHandler : CommandHandler,
        IRequestHandler<CreateFeatureCommand, Response<int>>,
        IRequestHandler<DeleteFeatureCommand, Response<int>>,
        IRequestHandler<UpdateFeatureCommand, Response<int>>
    {
        private readonly IFeatureRepository _featureRepository;
        public FeatureCommandHandler(IFeatureRepository FeatureRepository)
        {
            _featureRepository = FeatureRepository;
        }
        public Task<Response<int>> Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var Feature = new Domain.Entities.Feature()
            {
                Name = request.Name,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _featureRepository.Add(Feature);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteFeatureCommand request, CancellationToken cancellationToken)
        {
            var entity = _featureRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _featureRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _featureRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                _featureRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
