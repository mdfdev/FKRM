using FKRM.Domain.Validation.Group;
using System;
using System.Collections.Generic;
using System.Text;

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
