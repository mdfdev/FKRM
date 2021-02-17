using FKRM.Domain.Validation.AcademicCalendar;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.AcademicCalendar
{
    public class DeleteAcademicCalendarCommand : AcademicCalendarCommand
    {
        public DeleteAcademicCalendarCommand(Guid id)
        {
            ID = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new DeleteAcademicCalendarCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
