using FKRM.Domain.Validation.Branch;

namespace FKRM.Domain.Commands.Branch
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
