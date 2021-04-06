using FKRM.Domain.Validation.WorkedFor;
using System;

namespace FKRM.Domain.Commands.WorkedFor
{
    public class DeleteWorkedForCommand : WorkedForCommand
    {
        public DeleteWorkedForCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteWorkedForCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
