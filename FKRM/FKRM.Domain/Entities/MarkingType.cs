using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// مدل نمره دهی
    /// </summary>
    public class MarkingType : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
