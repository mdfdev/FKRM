using FKRM.Domain.Commands.Enrollment;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Enrollment
{
    public class UpdateEnrollmentCommandValidation : EnrollmentValidation<UpdateEnrollmentCommand>
    {
        public UpdateEnrollmentCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
