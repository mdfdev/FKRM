using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    /// <summary>
    /// مقطع تحصیلی دانشگاهی
    /// </summary>
    public class AcademicDegreeViewModel:BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("مقطع تحصیلی دانشگاهی")]
        public string Name { get; set; }
    }
}
