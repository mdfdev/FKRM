using FKRM.Application.Commands.Group;

namespace FKRM.Application.Validation.Group
{
    public class DeleteGroupCommandValidation : GroupValidation<DeleteGroupCommand>
    {
        public DeleteGroupCommandValidation()
        {
            ValidateId();
        }
    }
}
