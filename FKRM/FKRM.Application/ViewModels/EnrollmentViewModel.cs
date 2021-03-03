using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class EnrollmentViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("ظرفیت")]
        public int Capacity { get; set; }
    }
}
