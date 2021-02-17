using FKRM.Domain.Commands.School;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.School
{
    public class DeleteSchoolCommandValidation:SchoolValidation<DeleteSchoolCommand>
    {
        public DeleteSchoolCommandValidation()
        {
            ValidateId();
        }
    }
}
