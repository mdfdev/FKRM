using FKRM.Application.Commands.Branch;

namespace FKRM.Application.Validation.Branch
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
