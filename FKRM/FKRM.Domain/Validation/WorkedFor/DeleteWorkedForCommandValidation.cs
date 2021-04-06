using FKRM.Domain.Commands.WorkedFor;

namespace FKRM.Domain.Validation.WorkedFor
{
    public class DeleteWorkedForCommandValidation : WorkedForValidation<DeleteWorkedForCommand>
    {
        public DeleteWorkedForCommandValidation()
        {
            ValidateId();
        }
    }
}
