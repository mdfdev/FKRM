using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.OUType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.OUType
{
    public class CreateOUTypeCommand: OUTypeCommand
    {
        public CreateOUTypeCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateOUTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
