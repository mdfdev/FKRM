using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Schedule;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public ScheduleService(IScheduleRepository repository, IMediatorHandler bus, IMapper mapper)
        {
            _scheduleRepository = repository;
            _bus = bus;
            _autoMapper = mapper;
        }
        public IEnumerable<ScheduleViewModel> GetAll()
        {
            return _scheduleRepository.GetAll().ProjectTo<ScheduleViewModel>(_autoMapper.ConfigurationProvider);
        }

        public ScheduleViewModel GetById(Guid id)
        {
            return _autoMapper.Map<ScheduleViewModel>(_scheduleRepository.GetById(id));
        }

        public Task<Response<int>> Register(ScheduleViewModel scheduleViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<CreateScheduleCommand>(scheduleViewModel));
        }

        public Task<Response<int>> Remove(Guid id)
        {
           return (Task<Response<int>>)_bus.SendCommand(new DeleteScheduleCommand(id));
        }

        public Task<Response<int>> Update(ScheduleViewModel scheduleViewModel)
        {
            return (Task<Response<int>>)_bus.SendCommand(_autoMapper.Map<UpdateScheduleCommand>(scheduleViewModel));
        }

        public IEnumerable<ScheduleViewModel> GetPagedResponse(int pageNumber, int pageSize)
        {
            return _scheduleRepository.GetPagedReponse(pageNumber, pageSize).ProjectTo<ScheduleViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
