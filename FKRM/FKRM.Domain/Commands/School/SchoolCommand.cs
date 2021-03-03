using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.School
{
    public abstract class SchoolCommand : Command
    {
        public string Name { get; protected set; }
        public Guid ID { get; protected set; }
    }
}
