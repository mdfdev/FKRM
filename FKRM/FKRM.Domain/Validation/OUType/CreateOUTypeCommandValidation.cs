using FKRM.Domain.Commands.OUType;

namespace FKRM.Domain.Validation.OUType
{
    public class CreateOUTypeCommandValidation : OUTypeValidation<CreateOUTypeCommand>
    {
        public CreateOUTypeCommandValidation()
        {
            ValidateName();
        }
    }
}
