using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.OUType
{
    public abstract class OUTypeCommand:Command
    {
        public string Name { get; protected set; }
    }
}
