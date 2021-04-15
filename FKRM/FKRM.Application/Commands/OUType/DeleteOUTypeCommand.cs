using FKRM.Application.Validation.OUType;
using System;

namespace FKRM.Application.Commands.OUType
{
    public class DeleteOUTypeCommand : OUTypeCommand
    {
        public DeleteOUTypeCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteOUTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
