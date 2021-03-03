using FKRM.Domain.Validation.UnitType;
using System;

namespace FKRM.Domain.Commands.UnitType
{
    public class DeleteUnitTypeCommand : UnitTypeCommand
    {
        public DeleteUnitTypeCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteUnitTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
