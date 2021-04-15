using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.Staff
{
    public abstract class StaffCommand : Command
    {
        public Guid ID { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Phone { get; protected set; }
        public string Mobile { get; protected set; }
        public string NationalCode { get; protected set; }
        public Guid JobTitleId { get; protected set; }
        public Guid SchoolId { get; protected set; }
        public Guid AcademicCalendarId { get; protected set; }

    }
}
