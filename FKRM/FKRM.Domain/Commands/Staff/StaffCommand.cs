using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Staff
{
    public abstract class StaffCommand:Command
    {
        public Guid ID { get; protected set; }
        public string Name { get; protected set; }
    }
}
