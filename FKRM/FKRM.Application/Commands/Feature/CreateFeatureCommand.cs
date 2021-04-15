using FKRM.Application.Validation.Feature;

namespace FKRM.Application.Commands.Feature
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
