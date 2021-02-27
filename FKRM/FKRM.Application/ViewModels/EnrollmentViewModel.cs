using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class EnrollmentViewModel:BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("ظرفیت")]
        public int Capacity { get; set; }
    }
}
