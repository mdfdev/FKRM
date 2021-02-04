using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class MarkingTypeViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام")]
        public string Name { get; set; }
    }
}
