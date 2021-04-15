using FKRM.Application.Commands.AcademicCalendar;

namespace FKRM.Application.Validation.AcademicCalendar
{
    public class CreateAcademicCalendarCommandValidation : AcademicCalendarValidation<CreateAcademicCalendarCommand>
    {
        public CreateAcademicCalendarCommandValidation()
        {
            ValidateName();
        }
    }
}
