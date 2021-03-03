using FKRM.Domain.Validation.Feature;

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
