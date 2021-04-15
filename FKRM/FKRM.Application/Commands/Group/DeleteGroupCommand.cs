using FKRM.Application.Validation.Group;
using System;

namespace FKRM.Application.Commands.Group
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
