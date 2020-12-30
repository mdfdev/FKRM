using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Branch
{
    public abstract class BranchCommand:Command
    {
        public string Name { get; protected set; }
    }
}
