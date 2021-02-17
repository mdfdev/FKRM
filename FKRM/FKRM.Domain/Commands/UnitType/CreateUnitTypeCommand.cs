using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.UnitType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.UnitType
{
    public class CreateUnitTypeCommand: UnitTypeCommand
    {
        public CreateUnitTypeCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateUnitTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
