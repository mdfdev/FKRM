using FKRM.Domain.Commands.OUType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.OUType
{
    public class CreateOUTypeCommandValidation:OUTypeValidation<CreateOUTypeCommand>
    {
        public CreateOUTypeCommandValidation()
        {
            ValidateName();
        }
    }
}
