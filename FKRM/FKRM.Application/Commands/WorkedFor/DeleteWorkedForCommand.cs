using FKRM.Application.Validation.WorkedFor;
using System;

namespace FKRM.Application.Commands.WorkedFor
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
