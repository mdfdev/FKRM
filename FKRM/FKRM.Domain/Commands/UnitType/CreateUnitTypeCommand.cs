using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.UnitType
{
    public class CreateUnitTypeCommand: UnitTypeCommand
    {
        public CreateUnitTypeCommand(string name)
        {
            Name = name;
        }
    }
}
