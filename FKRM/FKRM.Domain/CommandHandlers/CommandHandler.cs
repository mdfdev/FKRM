using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Commands;
using FKRM.Domain.Core.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.CommandHandlers
{
    public class CommandHandler
    {
        private readonly IMediatorHandler _bus;
        public CommandHandler(IMediatorHandler bus)
        {
            _bus = bus;
        }
        protected void NotifyValidationErrors(Command message)
        {
            List<string> errorInfo = new List<string>();
            foreach (var error in message.ValidationResult.Errors)
            {
                _bus.RaiseEvent(new DomainNotification("", error.ErrorMessage));
            }
        }
    }
}
