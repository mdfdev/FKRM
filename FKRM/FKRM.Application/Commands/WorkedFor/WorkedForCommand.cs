using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.WorkedFor
{
    public abstract class WorkedForCommand : Command
    {
        public Guid ID { get; protected set; }
        public Guid SchoolId { get; set; }
        public Guid AcademicCalendarId { get; set; }
        public Guid StaffId { get; set; }

    }
}
