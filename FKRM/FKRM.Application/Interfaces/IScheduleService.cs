using FKRM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Interfaces
{
    public interface IScheduleService
    {
        ScheduleViewModel GetById(Guid id);
        void Register(ScheduleViewModel scheduleViewModel);
        IEnumerable<ScheduleViewModel> GetAll();
        void Update(ScheduleViewModel scheduleViewModel);
        void Remove(Guid id);
    }
}
