using FKRM.Application.Validation.WorkedFor;
using System;

namespace FKRM.Application.Commands.WorkedFor
{
    public class CreateWorkedForCommand : WorkedForCommand
    {
        public CreateWorkedForCommand(string name, Guid staffId, Guid schoolId, Guid academicCalendarId)
        {
            AcademicCalendarId = academicCalendarId;
            StaffId = staffId;
            SchoolId = schoolId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateWorkedForCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
