using FKRM.Domain.Common;
using System;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// اطلاعات ثبت نام کلاس
    /// </summary>
    public class Enrollment : BaseEntity
    {
        public Course Course { get; set; }
        public Guid CourseId { get; set; }
        public int Capacity { get; set; }
        public int DayOfTheWeek { get; set; }
        public int StartTime { get; set; }
        public int During { get; set; }
        public WorkedFor WorkedFor { get; set; }
        public Guid WorkedForId { get; set; }
    }
}
