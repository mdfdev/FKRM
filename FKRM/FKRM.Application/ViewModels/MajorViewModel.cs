using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    /// <summary>
    /// رشته
    /// </summary>
    public class MajorViewModel : BaseViewModel
    {
        /// <summary>
        /// نام رشته
        /// </summary>
        [Display(Name = "نام رشته", Prompt = "نام رشته")]
        [Required(ErrorMessage = "(*)")]
        public string Name { get; set; }
        /// <summary>
        /// کد رایانه ای
        /// </summary>
        [Display(Name = "کد رایانه ای", Prompt = "کد رایانه ای")]
        [Required(ErrorMessage = "(*)")]
        public string ComputerCode { get; set; }
        /// <summary>
        /// تعداد واحد الزامی
        /// </summary>
        [Display(Name = "تعداد واحد الزامی", Prompt = "تعداد واحد الزامی")]
        [Range(1, 120, ErrorMessage = "تعداد واحد الزامی باید بین 1 و 120 باشد.")]
        public int RequiredCredit { get; set; }
        /// <summary>
        /// تعداد واحد اختیاری یا انتخابی
        /// </summary>
        [Display(Name = "تعداد واحد اختیاری یا انتخابی", Prompt = "تعداد واحد اختیاری یا انتخابی")]
        [Range(1, 10, ErrorMessage = "تعداد واحد اختیاری یا انتخابی باید بین 0 و 10 باشد.")]
        public int OptionalElectiveCredit { get; set; }
        /// <summary>
        /// تعداد واحد فارغ التحصیلی
        /// </summary>
        [Display(Name = "تعداد واحد فارغ التحصیلی", Prompt = "تعداد واحد فارغ التحصیلی")]
        [Range(1, 120, ErrorMessage = "تعداد واحد فارغ التحصیلی باید بین 1 و 120 باشد.")]
        public int GraduationCredits { get; set; }
        [DisplayName("شاخه")]
        public string Branch { get; set; }
        [DisplayName("زمینه")]
        public string Area { get; set; }
        [DisplayName("گروه")]
        public string Group { get; set; }
        public Guid BranchId { get; set; }
        public Guid AreaId { get; set; }
        public Guid GroupId { get; set; }
        public SelectList Branches { get; set; }
        public SelectList Areas { get; set; }
        public SelectList Groups { get; set; }
    }
}
