using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// نوبت تحصیلی
    /// </summary>
    public class AcademicCalendar : IEntity
    {
        public int Id { get; set; }
        public string AcademicYear { get; set; }
        public string AcademicQuarter { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
