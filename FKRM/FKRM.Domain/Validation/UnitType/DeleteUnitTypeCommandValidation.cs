using FKRM.Domain.Commands.UnitType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.UnitType
{
    public class DeleteUnitTypeCommandValidation:UnitTypeValidation<DeleteUnitTypeCommand>
    {
        public DeleteUnitTypeCommandValidation()
        {
            ValidateId();
        }
    }
}
