using FKRM.Domain.Core.Commands;
using System;

namespace FKRM.Domain.Commands.Major
{
    public abstract class MajorCommand : Command
    {
        public Guid ID { get; protected set; }

        public string Name { get; protected set; }
        public string ComputerCode { get; protected set; }
        public int RequiredCredit { get; protected set; }
        public int OptionalElectiveCredit { get; protected set; }
        public int GraduationCredits { get; protected set; }
        public Guid GroupId { get; set; }

    }
}
