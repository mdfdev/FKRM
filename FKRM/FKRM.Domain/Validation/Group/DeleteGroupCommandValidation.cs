using FKRM.Domain.Commands.Group;

namespace FKRM.Domain.Validation.Group
{
    public class DeleteGroupCommandValidation : GroupValidation<DeleteGroupCommand>
    {
        public DeleteGroupCommandValidation()
        {
            ValidateId();
        }
    }
}
