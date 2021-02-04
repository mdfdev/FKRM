﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class UnitTypeViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام واحد سازمانی")]
        public string Name { get; set; }
    }
}
