using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.Enrollment
{
    public abstract class EnrollmentCommand : Command
    {
        public Guid ID { get; protected set; }

        public int Capacity { get; protected set; }
    }
}
