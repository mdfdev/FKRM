using FKRM.Application.Validation.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Commands.Notification
{
    public class CreateNotificationCommand : NotificationCommand
    {
        public CreateNotificationCommand(string subject,string body)
        {
            Subject = subject;
            Body = body;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateNotificationCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
