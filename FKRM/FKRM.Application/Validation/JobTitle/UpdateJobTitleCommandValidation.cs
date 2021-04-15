using FKRM.Application.Commands.JobTitle;

namespace FKRM.Application.Validation.JobTitle
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
