using FKRM.Domain.Commands.Group;

namespace FKRM.Domain.Validation.Group
{
    public class CreateGroupCommandValidation : GroupValidation<CreateGroupCommand>
    {
        public CreateGroupCommandValidation()
        {
            ValidateName();
        }
    }
}
