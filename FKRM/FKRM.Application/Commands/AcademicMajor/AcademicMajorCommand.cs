using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Application.Commands.AcademicMajor
{
    public abstract class AcademicMajorCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
    }
}
