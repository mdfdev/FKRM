using FKRM.Domain.Common;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// واحد سازمانی
    /// </summary>
    public class OUType : BaseEntity
    {
        /// <summary>
        /// نوع واحد سازمانی
        /// </summary>
        public string Name { get; set; }
        public ICollection<School> Schools { get; set; }
    }
}
