using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.AcademicCalendar
{
    public abstract class AcademicCalendarCommand : Command
    {
        public string Name { get; protected set; }
    }
}
