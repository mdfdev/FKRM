using FKRM.Domain.Common;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// مدل نمره دهی
    /// </summary>
    public class MarkingType : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
