using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// مدرسه
    /// </summary>
    /// <remarks>
    /// This class can add, subtract, multiply and divide.
    /// </remarks>
    public class School : IEntity
    {
        public int Id { get; set ; }
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
