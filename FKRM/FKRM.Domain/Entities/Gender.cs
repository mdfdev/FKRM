using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    public class Gender : IEntity
    {
        public int Id { get; set ; }
        public string Name { get; set; }
    }
}
