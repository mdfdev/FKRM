using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// جنسیت
    /// </summary>
    public class Gender : BaseEntity
    {
        /// <summary>
        /// نوع جنسیت
        /// </summary>
        public string Name { get; set; }

        public ICollection<School> Schools { get; set; }
    }
}
