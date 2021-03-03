﻿using FKRM.Domain.Common;
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
        public Feature Feature { get; set; }
        public OUType OUType { get; set; }
        public UnitType UnitType { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
