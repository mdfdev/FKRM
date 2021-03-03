using FKRM.Domain.Commands.Group;

namespace FKRM.Domain.Validation.Group
{
    public class UpdateGroupCommandValidation : GroupValidation<UpdateGroupCommand>
    {
        public UpdateGroupCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
