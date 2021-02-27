using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class AreaViewModel:BaseViewModel
    {
      
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام زمینه رشته")]
        public string Name { get; set; }

    }
}
