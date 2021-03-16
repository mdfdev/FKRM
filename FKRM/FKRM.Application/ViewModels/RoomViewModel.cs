using Microsoft.AspNetCore.Mvc.Rendering;
using System;
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
        [DisplayName("نام کلاس")]
        public string Name { get; set; }
        [DisplayName("مدرسه")]
        public string School { get; set; }
        public Guid SchoolId { get; set; }
        public SelectList Schools { get; set; }
    }
}
