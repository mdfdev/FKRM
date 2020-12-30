using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers.Gender
{
    class UpdateGenderCommandHandler : IRequestHandler<UpdateGenderCommand, Response<int>>
    {
        private readonly IGenderRepository _genderRepository;
        public UpdateGenderCommandHandler(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
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
                return Task.FromResult(new Response<int>(request.ID,""));
            }
        }
    }
}
