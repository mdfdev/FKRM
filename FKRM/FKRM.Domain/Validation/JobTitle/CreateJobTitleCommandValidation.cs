using FKRM.Domain.Commands.JobTitle;

namespace FKRM.Domain.Validation.JobTitle
{
    public class CreateJobTitleCommandValidation : JobTitleValidation<CreateJobTitleCommand>
    {
        public CreateJobTitleCommandValidation()
        {
            ValidateName();
        }
    }
}
