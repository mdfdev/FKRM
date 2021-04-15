using FKRM.Application.Commands.Major;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.CommandHandlers
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
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _majorRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.Name = request.Name;
                entity.ModifiedDate = request.ModifiedDate;
                entity.GroupId = request.GroupId;
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
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var major = new Domain.Entities.Major()
            {
                Name = request.Name,
                ComputerCode = request.ComputerCode,
                RequiredCredit = request.RequiredCredit,
                GraduationCredits = request.GraduationCredits,
                OptionalElectiveCredit = request.OptionalElectiveCredit,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate,
                GroupId = request.GroupId
            };
            _majorRepository.Add(major);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
