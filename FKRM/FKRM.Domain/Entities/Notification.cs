using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// نوتیفیکیشن
    /// </summary>
    public class Notification : BaseEntity
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// متن
        /// </summary>
        public string Body { get; set; }
        public Notification ParentNotification { get; set; }
        public Guid? ParentNotificationId { get; set; }
        /// <summary>
        /// تاریخ انقضاء
        /// </summary>
        public  DateTime ExpiryDate { get; set; }
        public ICollection<NotificationRecipient> NotificationRecipients { get; set; }

    }
}
