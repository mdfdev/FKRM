using FKRM.Application.Validation.Major;
using System;

namespace FKRM.Application.Commands.Major
{
    public class UpdateMajorCommand : MajorCommand
    {
        public UpdateMajorCommand(Guid id, string name, string computerCode, int requiredCredit, int optionalElectiveCredit, int graduationCredits, Guid groupId)
        {
            ID = id;
            Name = name;
            ComputerCode = computerCode;
            RequiredCredit = requiredCredit;
            OptionalElectiveCredit = optionalElectiveCredit;
            GraduationCredits = graduationCredits;
            GroupId = groupId;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateMajorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
