using FKRM.Domain.Common;
using System;
using System.Collections.Generic;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// مدرسه
    /// </summary>
    /// <remarks>
    /// This class can add, subtract, multiply and divide.
    /// </remarks>
    public class School : BaseEntity
    {
        /// <summary>
        /// نام مدرسه
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// کد مدرسه
        /// </summary>
        public string Code { get; set; }
        public Gender Gender { get; set; }
        public Guid GenderId { get; set; }
        public Feature Feature { get; set; }
        public Guid FeatureId { get; set; }
        public OUType OUType { get; set; }
        public Guid OUTypeId { get; set; }
        public UnitType UnitType { get; set; }
        public Guid UnitTypeId { get; set; }

        public Guid DistrictId { get; set; }
        public District District { get; set; }

        public School Subsidiary { get; set; }
        public Guid SubsidiaryId { get; set; }
        public ICollection<WorkedFor> WorkedFors { get; set; }

    }
}
