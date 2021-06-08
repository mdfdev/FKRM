using FKRM.Application.Validation.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Commands.Notification
{
    public class DeleteNotificationCommand : NotificationCommand
    {
        public DeleteNotificationCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteNotificationCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
