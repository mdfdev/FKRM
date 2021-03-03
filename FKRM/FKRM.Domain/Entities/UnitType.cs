using FKRM.Domain.Common;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// نوع اداره
    /// </summary>
    public class UnitType : BaseEntity
    {
        /// <summary>
        /// نوع اداره خصوصی یا دولتی
        /// </summary>
        public string Name { get; set; }
        public ICollection<School> Schools { get; set; }

    }
}
