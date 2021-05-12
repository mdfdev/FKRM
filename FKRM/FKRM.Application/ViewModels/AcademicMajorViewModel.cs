using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    /// <summary>
    /// رشته دانشگاهی
    /// </summary>

    public class AcademicMajorViewModel:BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("عنوان رشته دانشگاهی")]
        public string Name { get; set; }
    }
}
