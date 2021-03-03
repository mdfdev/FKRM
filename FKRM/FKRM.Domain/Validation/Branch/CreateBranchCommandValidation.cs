using FKRM.Domain.Commands.Branch;

namespace FKRM.Domain.Validation.Branch
{
    class CreateBranchCommandValidation : BranchValidation<CreateBranchCommand>
    {
        public CreateBranchCommandValidation()
        {
            ValidateName();
        }
    }
}
