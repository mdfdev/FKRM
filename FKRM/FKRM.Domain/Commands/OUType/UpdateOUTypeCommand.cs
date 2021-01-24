using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.OUType
{
    public class UpdateOUTypeCommand : OUTypeCommand
    {
        public UpdateOUTypeCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
