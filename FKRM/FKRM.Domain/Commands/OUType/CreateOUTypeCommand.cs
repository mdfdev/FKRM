using FKRM.Domain.Validation.OUType;

namespace FKRM.Domain.Commands.OUType
{
    public class CreateOUTypeCommand : OUTypeCommand
    {
        public CreateOUTypeCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateOUTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
