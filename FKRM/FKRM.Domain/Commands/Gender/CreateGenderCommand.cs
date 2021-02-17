using FKRM.Domain.Validation.Gender;

namespace FKRM.Domain.Commands.Gender
{
    public class CreateGenderCommand : GenderCommand
    {
        public CreateGenderCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateGenderCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
