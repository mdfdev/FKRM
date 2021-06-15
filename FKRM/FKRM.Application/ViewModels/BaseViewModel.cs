using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FKRM.Application.ViewModels
{
    public abstract class BaseViewModel
    {
        [Key]
        [DisplayName("ردیف")]
        public Guid Id { get; set; }
        [DisplayName("تاریخ ثبت")]
        public virtual String AddedDate { get; set; } = default;
        [DisplayName("تاریخ ویرایش")]
        public virtual String ModifiedDate { get; set; } = default;
        [DisplayName("آدرس IP")]
        public virtual String IPAddress { get; set; } = default;
    }
}
