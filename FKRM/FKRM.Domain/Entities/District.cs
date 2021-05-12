using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// منطقه
    /// </summary>
    public class District : BaseEntity
    {
        /// <summary>
        /// نام منطقه
        /// </summary>
        public string Name { get; set; }
        public ICollection<School> Schools { get; set; }
    }
}
