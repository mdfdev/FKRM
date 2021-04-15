using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.Area
{
    public abstract class AreaCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }

        public Guid BranchId { get; set; }

    }
}
