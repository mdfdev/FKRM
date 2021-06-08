using FKRM.Application.Commands.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Validation.Notification
{
    class CreateNotificationCommandValidation : NotificationValidation<CreateNotificationCommand>
    {
        public CreateNotificationCommandValidation()
        {
            ValidateSubject();
            ValidateBody();
        }
    }
}
