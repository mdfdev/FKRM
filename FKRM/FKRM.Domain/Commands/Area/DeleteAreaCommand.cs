using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Area
{
    public class DeleteAreaCommand : AreaCommand
    {
        public DeleteAreaCommand(Guid id)
        {
            ID = id;
        }
    }
}
