using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    /// <summary>
    /// پایه تحصیلی
    /// </summary>
    public class GradeViewModel:BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام")]
        public string Name { get; set; }
    }
}
