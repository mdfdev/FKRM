using FKRM.Application.Commands.JobTitle;

namespace FKRM.Application.Validation.JobTitle
{
    public class DeleteJobTitleCommandValidation : JobTitleValidation<DeleteJobTitleCommand>
    {
        public DeleteJobTitleCommandValidation()
        {
            ValidateId();
        }
    }
}
