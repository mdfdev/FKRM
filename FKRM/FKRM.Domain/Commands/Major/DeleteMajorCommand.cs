using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Major
{
    public class DeleteMajorCommand : MajorCommand
    {
        public DeleteMajorCommand(Guid id)
        {
            ID = id;
        }
    }
}
