using FKRM.Application.Commands.WorkedFor;

namespace FKRM.Application.Validation.WorkedFor
{
    public class DeleteWorkedForCommandValidation : WorkedForValidation<DeleteWorkedForCommand>
    {
        public DeleteWorkedForCommandValidation()
        {
            ValidateId();
        }
    }
}
