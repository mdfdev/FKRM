using FKRM.Domain.Commands.UnitType;

namespace FKRM.Domain.Validation.UnitType
{
    public class DeleteUnitTypeCommandValidation : UnitTypeValidation<DeleteUnitTypeCommand>
    {
        public DeleteUnitTypeCommandValidation()
        {
            ValidateId();
        }
    }
}
