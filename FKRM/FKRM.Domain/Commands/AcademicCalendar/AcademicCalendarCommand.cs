using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.AcademicCalendar
{
    public abstract class AcademicCalendarCommand : Command
    {
        public Guid ID { get; protected set; }

        public string AcademicYear { get; protected set; }
        public string AcademicQuarter { get; protected set; }
    }
}
