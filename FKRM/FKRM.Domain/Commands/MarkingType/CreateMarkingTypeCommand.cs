using FKRM.Domain.Validation.MarkingType;

namespace FKRM.Domain.Commands.MarkingType
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
