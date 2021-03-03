using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class AreaViewModel : BaseViewModel
    {

        [Required(ErrorMessage = "(*)")]
        [DisplayName("زمینه")]
        public string Name { get; set; }
        [DisplayName("شاخه")]
        public string Branch { get; set; }
        public Guid BranchId { get; set; }
        public SelectList Branches { get; set; }

    }
}
