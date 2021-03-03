using FKRM.Domain.Validation.OUType;
using System;

namespace FKRM.Domain.Commands.OUType
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
