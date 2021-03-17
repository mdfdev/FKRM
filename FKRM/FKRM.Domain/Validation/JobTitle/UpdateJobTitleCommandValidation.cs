using FKRM.Domain.Commands.JobTitle;

namespace FKRM.Domain.Validation.JobTitle
{
    public class UpdateJobTitleCommandValidation : JobTitleValidation<UpdateJobTitleCommand>
    {
        public UpdateJobTitleCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
