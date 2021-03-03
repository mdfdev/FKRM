using FKRM.Domain.Commands.OUType;

namespace FKRM.Domain.Validation.OUType
{
    public class DeleteOUTypeCommandValidation : OUTypeValidation<DeleteOUTypeCommand>
    {
        public DeleteOUTypeCommandValidation()
        {
            ValidateId();
        }
    }
}
