using FKRM.Domain.Validation.Area;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Area
{
    public class CreateAreaCommand:AreaCommand
    {
        public CreateAreaCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateAreaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
