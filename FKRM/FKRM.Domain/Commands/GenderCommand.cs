using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands
{
    public abstract class GenderCommand:Command
    {
        public string Name { get; protected set; }
    }
}
