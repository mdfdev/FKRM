using FKRM.Application.Commands.Group;

namespace FKRM.Application.Validation.Group
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
