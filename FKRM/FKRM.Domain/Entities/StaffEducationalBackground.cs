using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// سوابق تحصیلی پرسنل
    /// </summary>
    public class StaffEducationalBackground:BaseEntity
    {
        public AcademicDegree AcademicDegree { get; set; }
        public Guid AcademicDegreeId { get; set; }


        public AcademicMajor AcademicMajor { get; set; }
        public Guid AcademicMajorId { get; set; }

        public Staff Staff { get; set; }
        public Guid StaffId { get; set; }
    }
}
