﻿using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class BranchViewModel : BaseViewModel
    {

        [Required(ErrorMessage = "(*)")]
        [DisplayName("نام شاخه تحصیلی")]
        public string Name { get; set; }
    }
}
