using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.OUType
{
    public class CreateOUTypeCommand: OUTypeCommand
    {
        public CreateOUTypeCommand(string name)
        {
            Name = name;
        }
    }
}
