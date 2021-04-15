using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.Group
{
    public abstract class GroupCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
        public Guid AreaId { get; set; }
    }
}
