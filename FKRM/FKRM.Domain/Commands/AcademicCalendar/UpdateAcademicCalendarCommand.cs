using FKRM.Domain.Validation.AcademicCalendar;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.AcademicCalendar
{
    public class UpdateAcademicCalendarCommand: AcademicCalendarCommand
    {
        public UpdateAcademicCalendarCommand(Guid id,string academicYear)
        {
            ID = id;
            AcademicYear = academicYear;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateAcademicCalendarCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
