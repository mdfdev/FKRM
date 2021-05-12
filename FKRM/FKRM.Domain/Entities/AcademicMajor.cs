using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// رشته دانشگاهی
    /// </summary>
    public class AcademicMajor : BaseEntity
    {
        /// <summary>
        /// عنوان رشته دانشگاهی
        /// </summary>
        public string Name { get; set; }
        public ICollection<StaffEducationalBackground> staffEducationalBackgrounds { get; set; }
    }
}
