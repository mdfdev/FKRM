using FKRM.Domain.Commands.WorkedFor;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class WorkedForCommandHandler : CommandHandler,
        IRequestHandler<CreateWorkedForCommand, Response<int>>,
        IRequestHandler<DeleteWorkedForCommand, Response<int>>,
        IRequestHandler<UpdateWorkedForCommand, Response<int>>
    {
        private readonly IWorkedForRepository _workedForRepository;
        public WorkedForCommandHandler(IWorkedForRepository workedForRepository)
        {
            _workedForRepository = workedForRepository;
        }
        public Task<Response<int>> Handle(UpdateWorkedForCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _workedForRepository.GetById(request.ID);
            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.StaffId = request.StaffId;
                entity.SchoolId = request.SchoolId;
                entity.AcademicCalendarId = request.AcademicCalendarId;              
                _workedForRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }

        public Task<Response<int>> Handle(DeleteWorkedForCommand request, CancellationToken cancellationToken)
        {
            var entity = _workedForRepository.GetById(request.ID);
            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            _workedForRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(CreateWorkedForCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var workedFor = new Entities.WorkedFor()
            {
                StaffId = request.StaffId,
                SchoolId = request.SchoolId,
                AcademicCalendarId = request.AcademicCalendarId,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _workedForRepository.Add(workedFor);
            return Task.FromResult(new Response<int>(200));
        }
    }
}
