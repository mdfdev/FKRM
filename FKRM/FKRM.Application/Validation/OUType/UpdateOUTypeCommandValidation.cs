using FKRM.Application.Commands.OUType;

namespace FKRM.Application.Validation.OUType
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
