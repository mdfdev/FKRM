﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    /// <summary>
    /// برنامه زمانبندی
    /// </summary>
    public class StaffViewModel : BaseViewModel
    {
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
