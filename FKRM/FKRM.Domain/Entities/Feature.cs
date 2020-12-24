using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// ویژگی مدرسه
    /// </summary>
    public class Feature : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<School> Schools { get; set; }
    }
}
