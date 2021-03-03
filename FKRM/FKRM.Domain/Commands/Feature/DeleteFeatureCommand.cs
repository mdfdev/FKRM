using FKRM.Domain.Validation.Feature;
using System;

namespace FKRM.Domain.Commands.Feature
{
    public class DeleteFeatureCommand : FeatureCommand
    {
        public DeleteFeatureCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteFeatureCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
