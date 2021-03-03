using FKRM.Domain.Validation.AcademicCalendar;
using System;

namespace FKRM.Domain.Commands.AcademicCalendar
{
    public class UpdateAcademicCalendarCommand : AcademicCalendarCommand
    {
        public UpdateAcademicCalendarCommand(Guid id, string academicYear, string academicQuarter)
        {
            ID = id;
            AcademicYear = academicYear;
            AcademicQuarter = academicQuarter;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateAcademicCalendarCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
