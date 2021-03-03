using FKRM.Domain.Commands.OUType;

namespace FKRM.Domain.Validation.OUType
{
    public class UpdateOUTypeCommandValidation : OUTypeValidation<UpdateOUTypeCommand>
    {
        public UpdateOUTypeCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
