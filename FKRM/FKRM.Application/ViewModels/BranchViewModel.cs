using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class BranchViewModel : BaseViewModel
    {

        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام شاخه تحصیلی")]
        public string Name { get; set; }
    }
}
