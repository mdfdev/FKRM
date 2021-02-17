using FKRM.Domain.Commands.AcademicCalendar;
using System;
using System.Collections.Generic;
using System.Text;

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
