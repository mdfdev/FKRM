using FKRM.Domain.Commands.Schedule;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Domain.CommandHandlers
{
    public class ScheduleCommandHandler : CommandHandler,
        IRequestHandler<CreateScheduleCommand, Response<int>>,
        IRequestHandler<DeleteScheduleCommand, Response<int>>,
        IRequestHandler<UpdateScheduleCommand, Response<int>>
    {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleCommandHandler(IScheduleRepository ScheduleRepository)
        {
            _scheduleRepository = ScheduleRepository;
        }
        public Task<Response<int>> Handle(CreateScheduleCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var Schedule = new Entities.Schedule()
            {
                StartTime = request.StartTime,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _scheduleRepository.Add(Schedule);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteScheduleCommand request, CancellationToken cancellationToken)
        {
            var entity = _scheduleRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _scheduleRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateScheduleCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _scheduleRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.StartTime = request.StartTime;
                entity.ModifiedDate = request.ModifiedDate;
                _scheduleRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
