using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class AcademicCalendarService : IAcademicCalendarService
    {
        private IAcademicCalendarRepository _academicCalendarRepository;
        public AcademicCalendarService(IAcademicCalendarRepository repository)
        {
            _academicCalendarRepository = repository;
        }
        public AcademicCalendarViewModel GetAcademicCalendars()
        {
            return new AcademicCalendarViewModel()
            {
                academicCalendars = _academicCalendarRepository.GetAcademicCalendars()
            };
        }
    }
}
