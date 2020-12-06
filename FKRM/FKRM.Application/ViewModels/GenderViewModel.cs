using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class GenderViewModel
    {
        public IEnumerable<Gender> genders { get; set; }
    }
}
