using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class JobTitleViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("عنوان شغلی")]
        public string Title { get; set; }
    }
}
