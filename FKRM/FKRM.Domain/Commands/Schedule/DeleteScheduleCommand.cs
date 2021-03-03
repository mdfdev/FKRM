using FKRM.Domain.Validation.Schedule;
using System;

namespace FKRM.Domain.Commands.Schedule
{
    public class DeleteScheduleCommand : ScheduleCommand
    {
        public DeleteScheduleCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteScheduleCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
