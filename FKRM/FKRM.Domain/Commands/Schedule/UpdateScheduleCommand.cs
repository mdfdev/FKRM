using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Schedule
{
    public class UpdateScheduleCommand:ScheduleCommand
    {
        public UpdateScheduleCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
