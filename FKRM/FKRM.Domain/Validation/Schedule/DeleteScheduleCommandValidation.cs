using FKRM.Domain.Commands.Schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Schedule
{
    public class DeleteScheduleCommandValidation:ScheduleValidation<DeleteScheduleCommand>
    {
        public DeleteScheduleCommandValidation()
        {
            ValidateId();
        }
    }
}
