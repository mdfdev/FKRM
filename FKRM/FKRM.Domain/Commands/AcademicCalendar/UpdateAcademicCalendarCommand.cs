using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.AcademicCalendar
{
    public class UpdateAcademicCalendarCommand: AcademicCalendarCommand
    {
        public UpdateAcademicCalendarCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
