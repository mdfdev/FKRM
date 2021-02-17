using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class EnrollmentViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("ظرفیت")]
        public int Capacity { get; set; }
    }
}
