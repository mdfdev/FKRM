using FKRM.Application.Validation.OUType;
using System;

namespace FKRM.Application.Commands.OUType
{
    public class UpdateOUTypeCommand : OUTypeCommand
    {
        public UpdateOUTypeCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateOUTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
