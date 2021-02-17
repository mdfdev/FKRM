using FKRM.Domain.Commands.Major;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Major
{
    public class DeleteMajorCommandValidation:MajorValidation<DeleteMajorCommand>
    {
        public DeleteMajorCommandValidation()
        {
            ValidateId();
        }
    }
}
