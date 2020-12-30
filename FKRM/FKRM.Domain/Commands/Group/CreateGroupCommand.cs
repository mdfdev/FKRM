using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Group
{
    public class CreateGroupCommand:GroupCommand
    {
        public CreateGroupCommand(string name)
        {
            Name = name;
        }
    }
}
