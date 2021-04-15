
using FKRM.Application.Commands.WorkedFor;

namespace FKRM.Application.Validation.WorkedFor
{
    public class UpdateWorkedForCommandValidation : WorkedForValidation<UpdateWorkedForCommand>
    {
        public UpdateWorkedForCommandValidation()
        {
            ValidateId();
        }
    }
}
