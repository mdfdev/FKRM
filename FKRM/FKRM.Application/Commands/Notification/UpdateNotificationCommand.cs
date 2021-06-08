using FKRM.Application.Validation.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Commands.Notification
{
    public class UpdateNotificationCommand : NotificationCommand
    {
        public UpdateNotificationCommand(Guid id, string subject,string body)
        {
            ID = id;
            Subject = subject;
            Body = body;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateNotificationCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
