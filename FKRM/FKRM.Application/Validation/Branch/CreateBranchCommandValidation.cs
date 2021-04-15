using FKRM.Application.Commands.Branch;

namespace FKRM.Application.Validation.Branch
{
    class CreateBranchCommandValidation : BranchValidation<CreateBranchCommand>
    {
        public CreateBranchCommandValidation()
        {
            ValidateName();
        }
    }
}
