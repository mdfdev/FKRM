using FKRM.Application.Commands.Group;

namespace FKRM.Application.Validation.Group
{
    public class CreateGroupCommandValidation : GroupValidation<CreateGroupCommand>
    {
        public CreateGroupCommandValidation()
        {
            ValidateName();
        }
    }
}
