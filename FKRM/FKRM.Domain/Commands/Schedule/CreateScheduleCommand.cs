using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Schedule
{
    public class CreateScheduleCommand: ScheduleCommand
    {
        public CreateScheduleCommand(string name)
        {
            Name = name;
        }
    }
}
