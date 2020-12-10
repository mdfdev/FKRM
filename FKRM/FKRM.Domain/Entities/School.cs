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
        public Gender Gender { get; set; }
        public Feature Feature { get; set; }
        public OUType OUType { get; set; }
        public UnitType UnitType { get; set; }
    }
}
