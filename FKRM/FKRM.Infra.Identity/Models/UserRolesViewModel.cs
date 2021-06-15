using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Infra.Identity.Models
{
    public class UserRolesViewModel
    {
        public string Id { get; set; }
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; } = true;
        [Display(Name = "نقش ها")]
        public IEnumerable<string> Roles { get; set; }
    }
}
