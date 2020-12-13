using FKRM.Domain.Common;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// شاخه تحصیلی
    /// </summary>
    public class Branch : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public List<Area> Areas { get; set; }
    }
}
