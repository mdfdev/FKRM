﻿using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// درس
    /// </summary>
    public class Course : BaseEntity
    {
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
        /// <summary>
        /// ساعت هفتگی عملی
        /// </summary>
        public int PracticalWeeklyHours { get; set; }
        /// <summary>
        /// ساعت هفتگی عملی
        /// </summary>
        public int TheoreticalWeeklyHours { get; set; }

        public Guid MajorId { get; set; }
        public Major Major { get; set; }
        public Guid MarkingTypeId { get; set; }
        public MarkingType MarkingType { get; set; }
        public Guid GradeId { get; set; }
        public Grade Grade { get; set; }
        [JsonIgnore]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
