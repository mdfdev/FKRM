using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.Feature;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Feature
{
    public class CreateFeatureCommand : FeatureCommand
    {
        public CreateFeatureCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateFeatureCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
