using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class StaffViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("تلفن")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("موبایل")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("کدملی")]
        public string NationalCode { get; set; }
    }
}
