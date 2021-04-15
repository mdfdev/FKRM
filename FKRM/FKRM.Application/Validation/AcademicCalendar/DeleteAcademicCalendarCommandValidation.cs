using FKRM.Application.Commands.AcademicCalendar;

namespace FKRM.Application.Validation.AcademicCalendar
{
    public class DeleteAcademicCalendarCommandValidation : AcademicCalendarValidation<DeleteAcademicCalendarCommand>
    {
        public DeleteAcademicCalendarCommandValidation()
        {
            ValidateId();
        }
    }
}
