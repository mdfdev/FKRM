using FKRM.Application.Commands.UnitType;

namespace FKRM.Application.Validation.UnitType
{
    public class DeleteUnitTypeCommandValidation : UnitTypeValidation<DeleteUnitTypeCommand>
    {
        public DeleteUnitTypeCommandValidation()
        {
            ValidateId();
        }
    }
}
