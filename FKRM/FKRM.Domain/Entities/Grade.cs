using FKRM.Domain.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// پایه تحصیلی
    /// </summary>
    public class Grade : BaseEntity
    {
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Course> Courses { get; set; }

    }
}
