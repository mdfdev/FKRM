using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.AcademicCalendar;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class AcademicCalendarService : IAcademicCalendarService
    {
        private readonly IAcademicCalendarRepository _academicCalendarRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public AcademicCalendarService(IAcademicCalendarRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _academicCalendarRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public void Create(AcademicCalendarViewModel academicCalendarViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateAcademicCalendarCommand>(academicCalendarViewModel));
        }

        public IEnumerable<AcademicCalendarViewModel> GetAcademicCalendars()
        {
            return _academicCalendarRepository.GetAcademicCalendars().ProjectTo<AcademicCalendarViewModel>(_autoMapper.ConfigurationProvider);
        }

    }
}
