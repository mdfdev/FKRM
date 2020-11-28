using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    public class School : IEntity
    {
        public int Id { get; set ; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
