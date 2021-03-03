using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.AcademicCalendar;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public IEnumerable<AcademicCalendarViewModel> GetAll()
        {
            return _academicCalendarRepository.GetAll().ProjectTo<AcademicCalendarViewModel>(_autoMapper.ConfigurationProvider);
        }

        public AcademicCalendarViewModel GetById(Guid id)
        {
            return _autoMapper.Map<AcademicCalendarViewModel>(_academicCalendarRepository.GetById(id));
        }

        public Task<Response<int>> Register(AcademicCalendarViewModel academicCalendarViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateAcademicCalendarCommand>(academicCalendarViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
            return (Task<Response<int>>)_bus.SendCommand(new DeleteAcademicCalendarCommand(id));
        }

        public Task<Response<int>> Update(AcademicCalendarViewModel academicCalendarViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateAcademicCalendarCommand>(academicCalendarViewModel));
        }
        public IEnumerable<AcademicCalendarViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _academicCalendarRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<AcademicCalendarViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
