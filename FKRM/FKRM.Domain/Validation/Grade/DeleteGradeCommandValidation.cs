using FKRM.Domain.Commands.Grade;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Grade
{
    public class DeleteGradeCommandValidation:GradeValidation<DeleteGradeCommand>
    {
        public DeleteGradeCommandValidation()
        {
            ValidateId();
        }
    }
}
