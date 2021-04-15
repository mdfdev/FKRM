using FKRM.Application.Validation.UnitType;
using System;

namespace FKRM.Application.Commands.UnitType
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
