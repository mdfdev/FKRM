using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// درس
    /// </summary>
    public class Course : IEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// کد درس
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// نام درس
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// تعداد واحد
        /// </summary>
        public int Credits { get; set; }
        /// <summary>
        /// حد نصاب قبولی
        /// </summary>
        public int PassMark { get; set; }

        public Major Major { get; set; }
        public MarkingType MarkingType { get; set; }
        public Grade Grade { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
