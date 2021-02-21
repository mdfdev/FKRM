using FKRM.Domain.Commands.MarkingType;
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
    public class MarkingTypeCommandHandler : 
        IRequestHandler<CreateMarkingTypeCommand, Response<int>>,
        IRequestHandler<DeleteMarkingTypeCommand, Response<int>>,
        IRequestHandler<UpdateMarkingTypeCommand, Response<int>>
    {
        private readonly IMarkingTypeRepository _markingTypeRepository;
        public MarkingTypeCommandHandler(IMarkingTypeRepository MarkingTypeRepository ) 
        {
            _markingTypeRepository = MarkingTypeRepository;
        }
        public Task<Response<int>> Handle(CreateMarkingTypeCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400));
            }
            var MarkingType = new Entities.MarkingType()
            {
                Name = request.Name
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
            var entity = _markingTypeRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _markingTypeRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
