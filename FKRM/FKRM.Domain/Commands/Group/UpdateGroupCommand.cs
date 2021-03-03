using FKRM.Domain.Validation.Group;
using System;

namespace FKRM.Domain.Commands.Group
{
    public class UpdateGroupCommand : GroupCommand
    {
        public UpdateGroupCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateGroupCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
