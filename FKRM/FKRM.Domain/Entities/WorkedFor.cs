using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    public class WorkedFor : BaseEntity
    {
        public AcademicCalendar AcademicCalendar { get; set; }
        public Guid AcademicCalendarId { get; set; }
        public Staff Staff { get; set; }
        public Guid StaffId { get; set; }
        public School School { get; set; }
        public Guid SchoolId { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
