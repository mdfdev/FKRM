using FKRM.Application.Commands.UnitType;

namespace FKRM.Application.Validation.UnitType
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
