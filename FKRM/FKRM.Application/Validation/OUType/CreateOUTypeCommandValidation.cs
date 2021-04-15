using FKRM.Application.Commands.OUType;

namespace FKRM.Application.Validation.OUType
{
    public class CreateOUTypeCommandValidation : OUTypeValidation<CreateOUTypeCommand>
    {
        public CreateOUTypeCommandValidation()
        {
            ValidateName();
        }
    }
}
