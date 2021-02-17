using FKRM.Domain.Commands.UnitType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.UnitType
{
    public class CreateUnitTypeCommandValidation:UnitTypeValidation<CreateUnitTypeCommand>
    {
        public CreateUnitTypeCommandValidation()
        {
            ValidateName();
        }
    }
}
