using FKRM.Domain.Commands.UnitType;

namespace FKRM.Domain.Validation.UnitType
{
    public class UpdateUnitTypeCommandValidation : UnitTypeValidation<UpdateUnitTypeCommand>
    {
        public UpdateUnitTypeCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
