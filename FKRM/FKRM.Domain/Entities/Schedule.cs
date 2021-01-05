using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// برنامه زمانبندی
    /// </summary>
    public class Schedule : BaseEntity
    {
        public int DayOfTheWeek { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
