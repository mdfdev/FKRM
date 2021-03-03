using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
