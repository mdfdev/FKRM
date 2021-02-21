using FKRM.Domain.Commands.Feature;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class FeatureCommandHandler : 
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
                return Task.FromResult(new Response<int>(400));
            }
            var Feature = new Entities.Feature()
            {
                Name = request.Name
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
            var entity = _featureRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _featureRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
