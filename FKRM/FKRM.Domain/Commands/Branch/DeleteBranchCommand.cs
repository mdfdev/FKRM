using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Branch
{
    public class DeleteBranchCommand : BranchCommand
    {
        public DeleteBranchCommand(Guid id)
        {
            ID = id;
        }
    }
}
