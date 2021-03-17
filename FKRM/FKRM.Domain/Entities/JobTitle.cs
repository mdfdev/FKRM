using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// عنوان شغلی
    /// </summary>
    public class JobTitle:BaseEntity
    {
        public string Title { get; set; }
        public ICollection<Staff> Staffs { get; set; }
    }
}
