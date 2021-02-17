using FKRM.Domain.Validation.Schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Schedule
{
    public class UpdateScheduleCommand:ScheduleCommand
    {
        public UpdateScheduleCommand(Guid id,int startTime)
        {
            ID = id;
            StartTime = startTime;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateScheduleCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
