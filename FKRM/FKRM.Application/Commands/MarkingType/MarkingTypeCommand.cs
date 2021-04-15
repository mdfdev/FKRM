using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.MarkingType
{
    public abstract class MarkingTypeCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
