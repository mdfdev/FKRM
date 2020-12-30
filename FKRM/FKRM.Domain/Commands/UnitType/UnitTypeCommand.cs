using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.UnitType
{
    public abstract class UnitTypeCommand:Command
    {
        public string Name { get; protected set; }
    }
}
