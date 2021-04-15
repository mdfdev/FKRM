using FKRM.Application.Validation.Group;
using System;

namespace FKRM.Application.Commands.Group
{
    public class CreateGroupCommand : GroupCommand
    {
        public CreateGroupCommand(string name, Guid areaId)
        {
            Name = name;
            AreaId = areaId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateGroupCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
