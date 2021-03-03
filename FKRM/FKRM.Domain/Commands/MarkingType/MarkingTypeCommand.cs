using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.MarkingType
{
    public abstract class MarkingTypeCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
