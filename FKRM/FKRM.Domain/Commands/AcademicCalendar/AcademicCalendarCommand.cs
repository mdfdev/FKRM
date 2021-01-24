using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.AcademicCalendar
{
    public abstract class AcademicCalendarCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
