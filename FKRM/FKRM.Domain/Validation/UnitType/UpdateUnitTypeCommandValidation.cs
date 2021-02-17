using FKRM.Domain.Commands.UnitType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.UnitType
{
    public class UpdateUnitTypeCommandValidation:UnitTypeValidation<UpdateUnitTypeCommand>
    {
        public UpdateUnitTypeCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
