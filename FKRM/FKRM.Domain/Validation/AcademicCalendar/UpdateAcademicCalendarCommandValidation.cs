using FKRM.Domain.Commands.AcademicCalendar;

namespace FKRM.Domain.Validation.AcademicCalendar
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
