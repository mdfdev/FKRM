using FKRM.Domain.Validation.Feature;
using System;
using System.Collections.Generic;
using System.Text;

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
