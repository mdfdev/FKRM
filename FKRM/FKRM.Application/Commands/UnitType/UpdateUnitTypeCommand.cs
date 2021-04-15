using FKRM.Application.Validation.UnitType;
using System;

namespace FKRM.Application.Commands.UnitType
{
    public class UpdateUnitTypeCommand : UnitTypeCommand
    {
        public UpdateUnitTypeCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateUnitTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
