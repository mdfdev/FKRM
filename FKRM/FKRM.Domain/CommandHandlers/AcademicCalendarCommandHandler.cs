using FKRM.Domain.Commands.AcademicCalendar;
using FKRM.Domain.Core.Bus;
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
                return Task.FromResult(new Response<int>(400));
            }
            var AcademicCalendar = new Entities.AcademicCalendar()
            {
                AcademicYear = request.AcademicYear
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
            var entity = _academicCalendarRepository.GetById(request.ID);

            if (entity == null)
            {
                throw new ApiException($"گزینه مورد نظر یافت نشد.");
            }
            else
            {
                entity.AcademicYear = request.AcademicYear;
                _academicCalendarRepository.Update(entity);
                return Task.FromResult(new Response<int>(200));
            }
        }
    }
}
