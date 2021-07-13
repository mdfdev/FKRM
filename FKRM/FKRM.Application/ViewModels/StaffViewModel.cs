using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("عنوان شغلی")]
        public string JobTitle { get; set; }
        public Guid JobTitleId { get; set; }
        public SelectList JobTitles { get; set; }
        [DisplayName("مدرسه")]
        public string School { get; set; }
        public Guid SchoolId { get; set; }
        public SelectList Schools { get; set; }
        [DisplayName("سال تحصیلی")]
        public string AcademicCalendar { get; set; }
        public Guid AcademicCalendarId { get; set; }
        public SelectList AcademicCalendars { get; set; }

        [DisplayName("تاریخ تولد")]
        public string BirthDate { get; set; }
        [DisplayName("تاریخ اشتغال به کار")]
        public string HiringDate { get; set; }
        [DisplayName("ایمیل")]
        public string Email { get; set; }
        [DisplayName("بیوگرافی")]
        public string Bio { get; set; }
        [DisplayName("سن")]
        public string Age { get; set; }

        public IEnumerable<StaffEducationalBackgroundViewModel> staffEducationalBackgrounds { get; set; }
    }
}
