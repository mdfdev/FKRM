using FKRM.Domain.Validation.UnitType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.UnitType
{
    public class UpdateUnitTypeCommand : UnitTypeCommand
    {
        public UpdateUnitTypeCommand(Guid id,string name)
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
