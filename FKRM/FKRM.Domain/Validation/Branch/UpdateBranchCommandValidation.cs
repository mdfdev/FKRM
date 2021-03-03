using FKRM.Domain.Commands.Branch;

namespace FKRM.Domain.Validation.Branch
{
    public class UpdateBranchCommandValidation : BranchValidation<UpdateBranchCommand>
    {
        public UpdateBranchCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
