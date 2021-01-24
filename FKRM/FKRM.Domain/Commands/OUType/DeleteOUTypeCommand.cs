using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.OUType
{
    public class DeleteOUTypeCommand : OUTypeCommand
    {
        public DeleteOUTypeCommand(Guid id)
        {
            ID = id;
        }
    }
}
