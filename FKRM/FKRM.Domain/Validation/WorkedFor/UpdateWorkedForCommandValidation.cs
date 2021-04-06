
using FKRM.Domain.Commands.WorkedFor;

namespace FKRM.Domain.Validation.WorkedFor
{
    public class UpdateWorkedForCommandValidation : WorkedForValidation<UpdateWorkedForCommand>
    {
        public UpdateWorkedForCommandValidation()
        {
            ValidateId();
        }
    }
}
