using FKRM.Application.Commands.JobTitle;

namespace FKRM.Application.Validation.JobTitle
{
    public class CreateJobTitleCommandValidation : JobTitleValidation<CreateJobTitleCommand>
    {
        public CreateJobTitleCommandValidation()
        {
            ValidateName();
        }
    }
}
