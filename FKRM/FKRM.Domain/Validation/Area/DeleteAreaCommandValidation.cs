using FKRM.Domain.Commands.Area;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Area
{
    public class DeleteAreaCommandValidation : AreaValidation<DeleteAreaCommand>
    {
        public DeleteAreaCommandValidation()
        {
            ValidateName();
        }
    }
}
