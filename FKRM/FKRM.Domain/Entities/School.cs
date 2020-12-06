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

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public int FeatureId { get; set; }
        public Feature Feature { get; set; }

        public int OUTypeID { get; set; }
        public OUType OUType { get; set; }

        public int UnitTypeId { get; set; }
        public UnitType UnitType { get; set; }
    }
}
