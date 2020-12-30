using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers.Gender
{
  
    public class CreateGenderCommandHandler : IRequestHandler<CreateGenderCommand, Response<int>>
    {
        private readonly IGenderRepository _genderRepository;
        public CreateGenderCommandHandler(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }

        public Task<Response<int>> Handle(CreateGenderCommand request, CancellationToken cancellationToken)
        {
            var gender = new Entities.Gender()
            {
                Name = request.Name
            };
            _genderRepository.Add(gender);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
