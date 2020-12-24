using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// جنسیت
    /// </summary>
    public class Gender : IEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// نوع جنسیت
        /// </summary>
        public string Name { get; set; }

        public ICollection<School> Schools { get; set; }
    }
}
