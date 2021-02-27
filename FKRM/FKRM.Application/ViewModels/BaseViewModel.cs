using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public abstract class BaseViewModel
    {
        [Key]
        [DisplayName("ردیف")]
        public Guid Id { get; set; }
        [DisplayName("تاریخ ثبت")]
        public virtual String AddedDate { get; set; }
        [DisplayName("تاریخ ویرایش")]
        public virtual String ModifiedDate { get; set; }
    }
}
