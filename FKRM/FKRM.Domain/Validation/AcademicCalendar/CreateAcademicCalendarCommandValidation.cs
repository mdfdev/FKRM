using FKRM.Domain.Commands.AcademicCalendar;

namespace FKRM.Domain.Validation.AcademicCalendar
{
    public class CreateAcademicCalendarCommandValidation : AcademicCalendarValidation<CreateAcademicCalendarCommand>
    {
        public CreateAcademicCalendarCommandValidation()
        {
            ValidateName();
        }
    }
}
