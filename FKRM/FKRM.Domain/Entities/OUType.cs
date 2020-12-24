using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// واحد سازمانی
    /// </summary>
    public class OUType : IEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// نوع واحد سازمانی
        /// </summary>
        public string Name { get; set; }
        public ICollection<School> Schools { get; set; }
    }
}
