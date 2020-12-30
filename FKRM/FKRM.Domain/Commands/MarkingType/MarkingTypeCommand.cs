using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.MarkingType
{
    public abstract class MarkingTypeCommand:Command
    {
        public string Name { get; protected set; }
    }
}
