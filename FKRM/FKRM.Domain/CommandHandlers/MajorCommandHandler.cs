using FKRM.Domain.Commands.Major;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class MajorCommandHandler : IRequestHandler<CreateMajorCommand, Response<int>>,
        IRequestHandler<DeleteMajorCommand, Response<int>>,
        IRequestHandler<UpdateMajorCommand, Response<int>>
    {
        private readonly IMajorRepository _majorRepository;
        public MajorCommandHandler(IMajorRepository majorRepository)
        {
            _majorRepository = majorRepository;
        }
        public Task<Response<int>> Handle(UpdateMajorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Response<int>> Handle(DeleteMajorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
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
