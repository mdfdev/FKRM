using FKRM.Domain.Commands.OUType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.OUType
{
    public class UpdateOUTypeCommandValidation:OUTypeValidation<UpdateOUTypeCommand>
    {
        public UpdateOUTypeCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
