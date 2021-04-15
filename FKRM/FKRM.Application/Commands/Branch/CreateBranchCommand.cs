using FKRM.Application.Validation.Branch;

namespace FKRM.Application.Commands.Branch
{
    public class CreateBranchCommand : BranchCommand
    {
        public CreateBranchCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateBranchCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
