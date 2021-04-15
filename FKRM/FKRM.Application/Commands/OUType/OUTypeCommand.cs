using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.OUType
{
    public abstract class OUTypeCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
