using FKRM.Domain.Common;
using System;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// گروه رشته
    /// </summary>
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public Area Area { get; set; }
        public Guid AreaId { get; set; }
        public ICollection<Major> Majors { get; set; }
    }
}
