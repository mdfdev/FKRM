using FKRM.Application.Validation.AcademicCalendar;
using System;

namespace FKRM.Application.Commands.AcademicCalendar
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
