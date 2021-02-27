using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class AcademicCalendarViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("سال تحصیلی")]
        public string AcademicYear { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("ترم تحصیلی")]
        public string AcademicQuarter { get; set; }
    }
}
