using FKRM.Application.Validation.Grade;

namespace FKRM.Application.Commands.Grade
{
    public class CreateGradeCommand : GradeCommand
    {
        public CreateGradeCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateGradeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
