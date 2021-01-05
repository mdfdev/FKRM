using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

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
        public AcademicCalendar AcademicCalendar { get; set; }
        public Schedule Schedule { get; set; }

    }
}
