using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Commands.Notification
{
    public abstract class NotificationCommand : Command
    {
        public Guid ID { get; protected set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ExpiryDate { get; set; }
        public Guid ParentNotificationlId { get; protected set; }
    }
}
