using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Group
{
    public abstract class GroupCommand : Command
    {
        public string Name { get; protected set; }
    }
}
