using FKRM.Domain.Validation.Group;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Group
{
    public class CreateGroupCommand:GroupCommand
    {
        public CreateGroupCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateGroupCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
