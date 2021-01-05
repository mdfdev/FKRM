using FKRM.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Major
{
    public abstract class MajorCommand:Command
    {
        public string Name { get; protected set; }
        public string ComputerCode { get; protected set; }
        public int RequiredCredit { get; protected set; }
        public int OptionalElectiveCredit { get; protected set; }
        public int GraduationCredits { get; protected set; }
    }
}
