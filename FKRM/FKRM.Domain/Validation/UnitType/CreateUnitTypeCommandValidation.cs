using FKRM.Domain.Commands.UnitType;

namespace FKRM.Domain.Validation.UnitType
{
    public class CreateUnitTypeCommandValidation : UnitTypeValidation<CreateUnitTypeCommand>
    {
        public CreateUnitTypeCommandValidation()
        {
            ValidateName();
        }
    }
}
