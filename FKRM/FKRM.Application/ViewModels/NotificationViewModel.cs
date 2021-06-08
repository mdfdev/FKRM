using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class NotificationViewModel : BaseViewModel
    {
        [DisplayName("عنوان")]
        public string Subject { get; set; }
        [DisplayName("متن پیام")]
        public string Body { get; set; }
        [DisplayName("پیام اصلی")]
        public string ParentNotification { get; set; }
        public Guid ParentNotificationId { get; set; }
    }
}
