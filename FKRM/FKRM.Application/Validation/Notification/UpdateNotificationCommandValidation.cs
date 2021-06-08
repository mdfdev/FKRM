using FKRM.Application.Commands.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Validation.Notification
{
    class UpdateNotificationCommandValidation : NotificationValidation<UpdateNotificationCommand>
    {
        public UpdateNotificationCommandValidation()
        {
            ValidateId();
            ValidateBody();
            ValidateSubject();
        }
    }
}
