using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class DistrictViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام منطقه")]
        public string Name { get; set; }
    }
}
