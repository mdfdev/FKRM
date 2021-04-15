using FKRM.Application.Commands.AcademicCalendar;

namespace FKRM.Application.Validation.AcademicCalendar
{
    public class UpdateAcademicCalendarCommandValidation : AcademicCalendarValidation<UpdateAcademicCalendarCommand>
    {
        public UpdateAcademicCalendarCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
