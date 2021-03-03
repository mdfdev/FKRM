using FKRM.Domain.Common;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// کلاس
    /// </summary>
    public class Room : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public School School { get; set; }
    }
}
