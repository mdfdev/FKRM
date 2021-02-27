using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class CourseViewModel:BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("کد درس")]
        public string Code { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام درس")]
        public string Name { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("تعداد واحد")]
        public int Credits { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("حد نصاب قبولی")]
        public int PassMark { get; set; }
    }
}
