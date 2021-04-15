using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.Branch
{
    public abstract class BranchCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
