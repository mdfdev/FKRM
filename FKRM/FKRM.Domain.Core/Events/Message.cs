using FKRM.Domain.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
namespace FKRM.Domain.Core.Events
{
    public abstract class Message: IRequest<Response<int>>
    {
        public string MessageType { get; protected set; }
        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
