using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    /// <summary>
    /// نوع اداره
    /// </summary>
    public class UnitTypeViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام واحد سازمانی")]
        public string Name { get; set; }
    }
}
