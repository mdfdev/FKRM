using AutoMapper;
using AutoMapper.QueryableExtensions;
using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.Schedule;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class ScheduleService : IScheduleService
    {
        private IScheduleRepository _scheduleRepository;
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

        public void Register(ScheduleViewModel scheduleViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateScheduleCommand>(scheduleViewModel));
        }

        public void Remove(Guid id)
        {
            _bus.SendCommand(new DeleteScheduleCommand(id));
        }

        public void Update(ScheduleViewModel scheduleViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<UpdateScheduleCommand>(scheduleViewModel));
        }
    }
}
