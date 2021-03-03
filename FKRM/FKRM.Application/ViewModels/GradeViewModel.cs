using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    /// <summary>
    /// پایه تحصیلی
    /// </summary>
    public class GradeViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام")]
        public string Name { get; set; }
    }
}
