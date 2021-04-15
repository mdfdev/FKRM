using FKRM.Application.Commands.AcademicCalendar;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Exceptions;
using FKRM.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FKRM.Application.CommandHandlers
{
    public class AcademicCalendarCommandHandler : CommandHandler,
        IRequestHandler<CreateAcademicCalendarCommand, Response<int>>,
        IRequestHandler<DeleteAcademicCalendarCommand, Response<int>>,
        IRequestHandler<UpdateAcademicCalendarCommand, Response<int>>
    {
        private readonly IAcademicCalendarRepository _academicCalendarRepository;
        public AcademicCalendarCommandHandler(IAcademicCalendarRepository AcademicCalendarRepository)
        {
            _academicCalendarRepository = AcademicCalendarRepository;
        }
        public Task<Response<int>> Handle(CreateAcademicCalendarCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var AcademicCalendar = new Domain.Entities.AcademicCalendar()
            {
                AcademicYear = request.AcademicYear,
                AcademicQuarter=request.AcademicQuarter,
                ModifiedDate = request.ModifiedDate,
                AddedDate = request.AddedDate
            };
            _academicCalendarRepository.Add(AcademicCalendar);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(DeleteAcademicCalendarCommand request, CancellationToken cancellationToken)
        {
            var entity = _academicCalendarRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }

            _academicCalendarRepository.Remove(request.ID);
            return Task.FromResult(new Response<int>(200));
        }

        public Task<Response<int>> Handle(UpdateAcademicCalendarCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(new Response<int>(400, GetErrors(request)));
            }
            var entity = _academicCalendarRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.AcademicYear = request.AcademicYear;
                entity.AcademicQuarter = request.AcademicQuarter;
                entity.ModifiedDate = request.ModifiedDate;
                _academicCalendarRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
