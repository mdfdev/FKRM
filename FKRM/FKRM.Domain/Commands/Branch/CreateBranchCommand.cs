using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Branch
{
    public class CreateBranchCommand: BranchCommand
    {
        public CreateBranchCommand(string name)
        {
            Name = name;
        }
    }
}
