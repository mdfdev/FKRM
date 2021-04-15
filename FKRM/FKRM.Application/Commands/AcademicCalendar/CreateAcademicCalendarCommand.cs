using FKRM.Application.Validation.AcademicCalendar;

namespace FKRM.Application.Commands.AcademicCalendar
{
    public class CreateAcademicCalendarCommand : AcademicCalendarCommand
    {
        public CreateAcademicCalendarCommand(string academicYear, string academicQuarter)
        {
            AcademicYear = academicYear;
            AcademicQuarter = academicQuarter;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateAcademicCalendarCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
