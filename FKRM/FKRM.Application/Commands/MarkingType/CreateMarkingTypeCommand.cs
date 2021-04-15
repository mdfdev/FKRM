using FKRM.Application.Validation.MarkingType;

namespace FKRM.Application.Commands.MarkingType
{
    public class CreateMarkingTypeCommand : MarkingTypeCommand
    {
        public CreateMarkingTypeCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateMarkingTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
