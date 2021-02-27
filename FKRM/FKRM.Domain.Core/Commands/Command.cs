using FKRM.Domain.Core.Wrappers;
using System;
using FluentValidation.Results;
using MediatR;

namespace FKRM.Domain.Core.Commands
{
    public abstract class Command : IRequest<Response<int>>
    {  
        public DateTime AddedDate { get; protected set; }
        public DateTime ModifiedDate { get;protected set; }
        public ValidationResult ValidationResult { get; set; }
        public string MessageType { get; protected set; }
        public abstract bool IsValid();
    }
}
