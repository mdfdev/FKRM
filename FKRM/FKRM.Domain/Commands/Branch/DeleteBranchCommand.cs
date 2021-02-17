using FKRM.Domain.Validation.Branch;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Branch
{
    public class DeleteBranchCommand : BranchCommand
    {
        public DeleteBranchCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteBranchCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
