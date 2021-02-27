using FKRM.Domain.Commands.Major;
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
    public class MajorCommandHandler : CommandHandler,
        IRequestHandler<CreateMajorCommand, Response<int>>,
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
            var entity = _majorRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                _majorRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }

        public Task<Response<int>> Handle(DeleteMajorCommand request, CancellationToken cancellationToken)
        {
            var entity = _majorRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _majorRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
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
