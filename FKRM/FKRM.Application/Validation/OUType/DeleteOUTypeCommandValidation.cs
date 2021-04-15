using FKRM.Application.Commands.OUType;

namespace FKRM.Application.Validation.OUType
{
    public class DeleteOUTypeCommandValidation : OUTypeValidation<DeleteOUTypeCommand>
    {
        public DeleteOUTypeCommandValidation()
        {
            ValidateId();
        }
    }
}
