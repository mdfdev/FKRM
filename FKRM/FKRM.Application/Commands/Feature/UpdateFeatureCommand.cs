using FKRM.Application.Validation.Feature;
using System;

namespace FKRM.Application.Commands.Feature
{
    public class UpdateFeatureCommand : FeatureCommand
    {
        public UpdateFeatureCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateFeatureCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
