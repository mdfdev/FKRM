using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
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
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        [JsonIgnore]
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
