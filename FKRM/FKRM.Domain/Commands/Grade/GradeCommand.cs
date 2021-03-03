using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.Grade
{
    public abstract class GradeCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
