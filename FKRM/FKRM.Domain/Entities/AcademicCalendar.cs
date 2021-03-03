using FKRM.Domain.Common;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// نوبت تحصیلی
    /// </summary>
    public class AcademicCalendar : BaseEntity
    {
        public string AcademicYear { get; set; }
        public string AcademicQuarter { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
