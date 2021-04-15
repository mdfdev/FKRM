using FKRM.Application.Validation.Branch;
using System;

namespace FKRM.Application.Commands.Branch
{
    public class UpdateBranchCommand : BranchCommand
    {
        public UpdateBranchCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateBranchCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
