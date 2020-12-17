using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class ScheduleService : IScheduleService
    {
        private IScheduleRepository _scheduleRepository;
        public ScheduleService(IScheduleRepository repository)
        {
            _scheduleRepository = repository;
        }
        public ScheduleViewModel GetSchedules()
        {
            return new ScheduleViewModel()
            {
                schedules=_scheduleRepository.GetSchedules()
            };
        }
    }
}
