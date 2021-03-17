using FKRM.Domain.Common;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// اطلاعات ثبت نام کلاس
    /// </summary>
    public class Enrollment : BaseEntity
    {
        public Staff Staff { get; set; }
        public Course Course { get; set; }
        public Room Room { get; set; }
        public int Capacity { get; set; }
        public int DayOfTheWeek { get; set; }
        public int StartTime { get; set; }
        public int During { get; set; }
        public AcademicCalendar AcademicCalendar { get; set; }
    }
}
