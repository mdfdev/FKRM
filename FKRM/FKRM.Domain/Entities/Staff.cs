using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// پرسنل
    /// </summary>
    public class Staff : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalCode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HiringDate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public JobTitle JobTitle { get; set; }
        public Guid JobTitleId { get; set; }
     
        public ICollection<WorkedFor> WorkedFors { get; set; }
        public ICollection<StaffEducationalBackground> StaffEducationalBackgrounds { get; set; }

    }
}
