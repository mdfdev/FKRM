using FKRM.Domain.Commands.Area;

namespace FKRM.Domain.Validation.Area
{
    public class CreateAreaCommandValidation : AreaValidation<CreateAreaCommand>
    {
        public CreateAreaCommandValidation()
        {
            ValidateName();
        }
    }
}
