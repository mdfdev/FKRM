using FKRM.Domain.Validation.AcademicCalendar;

namespace FKRM.Domain.Commands.AcademicCalendar
{
    public class CreateAcademicCalendarCommand : AcademicCalendarCommand
    {
        public CreateAcademicCalendarCommand(string academicYear, string academicQuarter)
        {
            AcademicYear = academicYear;
            AcademicYear = academicQuarter;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateAcademicCalendarCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
