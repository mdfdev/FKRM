using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class ScheduleViewModel
    {
        public IEnumerable<Schedule> schedules { get; set; }
    }
}
