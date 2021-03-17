using FKRM.Domain.Commands.JobTitle;

namespace FKRM.Domain.Validation.JobTitle
{
    public class DeleteJobTitleCommandValidation : JobTitleValidation<DeleteJobTitleCommand>
    {
        public DeleteJobTitleCommandValidation()
        {
            ValidateId();
        }
    }
}
