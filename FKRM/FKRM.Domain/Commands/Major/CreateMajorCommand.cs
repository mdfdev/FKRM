using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Major
{
    public class CreateMajorCommand: MajorCommand
    {
        public CreateMajorCommand(string name,string computerCode,int requiredCredit,int optionalElectiveCredit ,int graduationCredits )
        {
            Name = name;
            ComputerCode = computerCode;
            RequiredCredit = requiredCredit;
            OptionalElectiveCredit = optionalElectiveCredit;
            GraduationCredits = graduationCredits;
        }
    }
}
