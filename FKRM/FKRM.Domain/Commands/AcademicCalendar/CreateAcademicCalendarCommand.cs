using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.AcademicCalendar
{
    public class CreateAcademicCalendarCommand : AcademicCalendarCommand
    {
        public CreateAcademicCalendarCommand(string name)
        {
            Name = name;
        }
    }
}
