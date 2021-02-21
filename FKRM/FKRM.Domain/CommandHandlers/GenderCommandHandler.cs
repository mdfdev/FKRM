using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class GenderCommandHandler :
        IRequestHandler<CreateGenderCommand, Response<int>>,
        IRequestHandler<DeleteGenderCommand, Response<int>>,
        IRequestHandler<UpdateGenderCommand, Response<int>>
    {
        private readonly IGenderRepository _genderRepository;

        public GenderCommandHandler(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }
        public Task<Response<int>> Handle(CreateGenderCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400));
            }
            var gender = new Entities.Gender()
            {
                Name = request.Name
            };
            _genderRepository.Add(gender);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteGenderCommand request, CancellationToken cancellationToken)
        {
            var entity = _genderRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _genderRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateGenderCommand request, CancellationToken cancellationToken)
        {
            var entity = _genderRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _genderRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
