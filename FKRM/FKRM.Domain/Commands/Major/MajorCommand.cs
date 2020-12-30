using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Major
{
    public abstract class MajorCommand:Command
    {
        public string Name { get; protected set; }
    }
}
