using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class ScheduleViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام")]
        public int StartTime { get; set; }
    }
}
