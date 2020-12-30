using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Grade
{
    public abstract class GradeCommand:Command
    {
        public string Name { get; protected set; }
    }
}
