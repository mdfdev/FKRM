using FKRM.Application.Validation.District;

namespace FKRM.Application.Commands.District
{
    public class CreateDistrictCommand : DistrictCommand
    {
        public CreateDistrictCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateDistrictCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
