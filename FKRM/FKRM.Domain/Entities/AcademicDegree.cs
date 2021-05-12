using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// مدرک تحصیلی
    /// </summary>
    public class AcademicDegree : BaseEntity
    {
        /// <summary>
        /// عنوان مدرک
        /// </summary>
        public string Name { get; set; }
        public ICollection<StaffEducationalBackground> staffEducationalBackgrounds { get; set; }

    }
}
