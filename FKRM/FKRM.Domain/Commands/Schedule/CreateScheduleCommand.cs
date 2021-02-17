using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.Schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Schedule
{
    public class CreateScheduleCommand: ScheduleCommand
    {
        public CreateScheduleCommand(int startTime)
        {
            StartTime = startTime;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateScheduleCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
