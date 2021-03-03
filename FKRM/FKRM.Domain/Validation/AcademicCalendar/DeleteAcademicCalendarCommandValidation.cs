using FKRM.Domain.Commands.AcademicCalendar;

namespace FKRM.Domain.Validation.AcademicCalendar
{
    public class DeleteAcademicCalendarCommandValidation : AcademicCalendarValidation<DeleteAcademicCalendarCommand>
    {
        public DeleteAcademicCalendarCommandValidation()
        {
            ValidateId();
        }
    }
}
