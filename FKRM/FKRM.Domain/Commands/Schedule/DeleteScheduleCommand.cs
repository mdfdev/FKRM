using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Schedule
{
    public class DeleteScheduleCommand : ScheduleCommand
    {
        public DeleteScheduleCommand(Guid id)
        {
            ID = id;
        }
    }
}
