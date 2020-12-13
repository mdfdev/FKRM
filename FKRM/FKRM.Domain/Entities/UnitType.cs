using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// نوع اداره
    /// </summary>
    public class UnitType : IEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// نوع اداره خصوصی یا دولتی
        /// </summary>
        public string Name { get; set; }
        public List<School> Schools { get; set; }

    }
}
