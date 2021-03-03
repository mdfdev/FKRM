using FKRM.Domain.Validation.Group;
using System;

namespace FKRM.Domain.Commands.Group
{
    public class DeleteGroupCommand : GroupCommand
    {
        public DeleteGroupCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteGroupCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
