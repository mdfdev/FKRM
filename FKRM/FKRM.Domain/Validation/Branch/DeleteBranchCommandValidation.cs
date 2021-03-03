using FKRM.Domain.Commands.Branch;

namespace FKRM.Domain.Validation.Branch
{
    public class DeleteBranchCommandValidation : BranchValidation<DeleteBranchCommand>
    {
        public DeleteBranchCommandValidation()
        {
            ValidateId();
        }
    }
}
