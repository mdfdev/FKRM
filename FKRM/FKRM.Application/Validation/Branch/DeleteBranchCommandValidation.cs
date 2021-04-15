using FKRM.Application.Commands.Branch;

namespace FKRM.Application.Validation.Branch
{
    public class DeleteBranchCommandValidation : BranchValidation<DeleteBranchCommand>
    {
        public DeleteBranchCommandValidation()
        {
            ValidateId();
        }
    }
}
