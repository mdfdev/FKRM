using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Commands.Major;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers.Major
{
  
    public class CreateMajorCommandHandler : IRequestHandler<CreateMajorCommand, Response<int>>
    {
        private readonly IMajorRepository _majorRepository;
        public CreateMajorCommandHandler(IMajorRepository majorRepository)
        {
            _majorRepository = majorRepository;
        }

        public Task<Response<int>> Handle(CreateMajorCommand request, CancellationToken cancellationToken)
        {
            var major = new Entities.Major()
            {
                Name = request.Name,
                ComputerCode = request.ComputerCode,
                RequiredCredit = request.RequiredCredit,
                GraduationCredits = request.GraduationCredits,
                OptionalElectiveCredit = request.OptionalElectiveCredit
            };
            _majorRepository.Add(major);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
