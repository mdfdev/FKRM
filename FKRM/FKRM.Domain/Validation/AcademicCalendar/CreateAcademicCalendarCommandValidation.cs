using FKRM.Domain.Commands.AcademicCalendar;
using System;
using System.Collections.Generic;
using System.Text;

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
