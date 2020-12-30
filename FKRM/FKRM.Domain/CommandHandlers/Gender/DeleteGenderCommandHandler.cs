using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers.Gender
{

    public class DeleteGenderCommandHandler : IRequestHandler<DeleteGenderCommand, Response<int>>
    {
        private readonly IGenderRepository _genderRepository;
        public DeleteGenderCommandHandler(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }
        public Task<Response<int>> Handle(DeleteGenderCommand request, CancellationToken cancellationToken)
        {
            var entity = _genderRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _genderRepository.Delete(entity);
            return Task.FromResult(new Response<int>(request.ID));
        }
    }
}
