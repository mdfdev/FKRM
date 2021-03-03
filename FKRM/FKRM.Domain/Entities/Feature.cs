using FKRM.Domain.Common;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// ویژگی مدرسه
    /// </summary>
    public class Feature : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<School> Schools { get; set; }
    }
}
