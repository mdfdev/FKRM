using FKRM.Application.Commands.UnitType;

namespace FKRM.Application.Validation.UnitType
{
    public class CreateUnitTypeCommandValidation : UnitTypeValidation<CreateUnitTypeCommand>
    {
        public CreateUnitTypeCommandValidation()
        {
            ValidateName();
        }
    }
}
