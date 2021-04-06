using FKRM.Domain.Validation.WorkedFor;
using System;

namespace FKRM.Domain.Commands.WorkedFor
{
    public class UpdateWorkedForCommand : WorkedForCommand
    {
        public UpdateWorkedForCommand(Guid id, Guid staffId,Guid schoolId,Guid academicCalendarId)
        {
            ID = id;
            StaffId = staffId;
            SchoolId = schoolId;
            AcademicCalendarId = academicCalendarId;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateWorkedForCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
