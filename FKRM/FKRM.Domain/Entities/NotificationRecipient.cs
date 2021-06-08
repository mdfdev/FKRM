using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Entities
{
    /// <summary>
    /// گیرنده نوتیفیکیشن
    /// </summary>
    public class NotificationRecipient : BaseEntity
    {
        public Guid RecipientId { get; set; }
        public Guid RecipientGroupId { get; set; }
        public Guid NotificationId { get; set; }
        public Notification Notification { get; set; }
    }
}
