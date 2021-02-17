using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.Major;
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
        public override bool IsValid()
        {
            ValidationResult = new CreateMajorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
