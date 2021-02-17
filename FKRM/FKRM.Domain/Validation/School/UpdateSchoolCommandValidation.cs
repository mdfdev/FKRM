using FKRM.Domain.Commands.School;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.School
{
    public class UpdateSchoolCommandValidation:SchoolValidation<UpdateSchoolCommand>
    {
        public UpdateSchoolCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
