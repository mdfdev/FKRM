using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// گروه رشته
    /// </summary>
    public class Group : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Area Area { get; set; }
        public ICollection<Major> Majors { get; set; }
    }
}
