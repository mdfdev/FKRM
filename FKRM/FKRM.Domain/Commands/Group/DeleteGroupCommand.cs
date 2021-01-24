using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Group
{
    public class DeleteGroupCommand : GroupCommand
    {
        public DeleteGroupCommand(Guid id)
        {
            ID = id;
        }
    }
}
