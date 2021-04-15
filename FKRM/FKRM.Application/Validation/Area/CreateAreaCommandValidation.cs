using FKRM.Application.Commands.Area;

namespace FKRM.Application.Validation.Area
{
    public class CreateAreaCommandValidation : AreaValidation<CreateAreaCommand>
    {
        public CreateAreaCommandValidation()
        {
            ValidateName();
        }
    }
}
