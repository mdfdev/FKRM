using FKRM.Application.Validation.OUType;

namespace FKRM.Application.Commands.OUType
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
