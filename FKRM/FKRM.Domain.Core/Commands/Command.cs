using FKRM.Domain.Core.Wrappers;
using System;
using FluentValidation.Results;
using MediatR;
using FKRM.Domain.Core.Events;

namespace FKRM.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
        public abstract bool IsValid();
    }
}
