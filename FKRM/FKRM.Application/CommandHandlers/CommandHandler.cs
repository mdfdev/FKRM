﻿using FKRM.Domain.Core.Commands;
using System.Collections.Generic;

namespace FKRM.Application.CommandHandlers
{
    public class CommandHandler
    {
        protected List<string> GetErrors(Command message)
        {
            List<string> errorInfo = new List<string>();
            foreach (var error in message.ValidationResult.Errors)
            {
                errorInfo.Add(error.ErrorMessage);
            }
            return errorInfo;
        }
    }
}