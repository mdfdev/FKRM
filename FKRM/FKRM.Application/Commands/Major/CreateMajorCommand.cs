using FKRM.Application.Validation.Major;
using System;

namespace FKRM.Application.Commands.Major
{
    public class CreateMajorCommand : MajorCommand
    {
        public CreateMajorCommand(string name, string computerCode, int requiredCredit, int optionalElectiveCredit, int graduationCredits, Guid groupId)
        {
            Name = name;
            ComputerCode = computerCode;
            RequiredCredit = requiredCredit;
            OptionalElectiveCredit = optionalElectiveCredit;
            GraduationCredits = graduationCredits;
            GroupId = groupId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateMajorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
