using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    public class Room : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
        public ICollection<Enrollment> Enrollments { get; set; }
        public School School { get; set; }
    }
}
