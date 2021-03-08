using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public class GroupViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "(*)")]
        [DisplayName("گروه")]
        public string Name { get; set; }
        [DisplayName("زمینه")]
        public string Area { get; set; }
        [DisplayName("شاخه")]
        public string Branch { get; set; }
        public Guid BranchId { get; set; }
        public Guid AreaId { get; set; }
        //public SelectList Areas { get; set; }
        public SelectList Branches { get; set; }
    }
}
