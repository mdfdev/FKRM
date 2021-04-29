using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    public class District : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<School> Schools { get; set; }
    }
}
