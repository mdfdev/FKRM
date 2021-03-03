using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    /// <summary>
    /// کلاس
    /// </summary>
    public class RoomViewModel : BaseViewModel
    {

        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام")]
        public string Name { get; set; }
    }
}
