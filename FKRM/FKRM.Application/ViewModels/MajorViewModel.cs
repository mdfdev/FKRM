using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class MajorViewModel
    {
        /// <summary>
        /// نام رشته
        /// </summary>
        [Display(Name = "نام رشته",Prompt = "نام رشته")]
        public string Name { get; set; }
        /// <summary>
        /// کد رایانه ای
        /// </summary>
        [Display(Name = "کد رایانه ای",Prompt = "کد رایانه ای")]
        public string ComputerCode { get; set; }
        /// <summary>
        /// تعداد واحد الزامی
        /// </summary>
        [Display(Name = "تعداد واحد الزامی", Prompt = "تعداد واحد الزامی")]
        public int RequiredCredit { get; set; }
        /// <summary>
        /// تعداد واحد اختیاری یا انتخابی
        /// </summary>
        [Display(Name = "تعداد واحد اختیاری یا انتخابی", Prompt = "تعداد واحد اختیاری یا انتخابی")]
        public int OptionalElectiveCredit { get; set; }
        /// <summary>
        /// تعداد واحد فارغ التحصیلی
        /// </summary>
        [Display(Name = "تعداد واحد فارغ التحصیلی",Prompt = "تعداد واحد فارغ التحصیلی")]
        public int GraduationCredits { get; set; }
    }
}
