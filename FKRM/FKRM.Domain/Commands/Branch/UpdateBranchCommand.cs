using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Branch
{
    public class UpdateBranchCommand : BranchCommand
    {
        public UpdateBranchCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
