using FKRM.Domain.Common;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// شاخه تحصیلی
    /// </summary>
    public class Branch : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Area> Areas { get; set; }
    }
}
