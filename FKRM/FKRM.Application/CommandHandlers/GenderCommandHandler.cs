using FKRM.Application.Commands.Gender;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.CommandHandlers
{
    public class GenderCommandHandler : CommandHandler,
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
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var gender = new Domain.Entities.Gender()
            {
                Name = request.Name,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
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
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _genderRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                _genderRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
