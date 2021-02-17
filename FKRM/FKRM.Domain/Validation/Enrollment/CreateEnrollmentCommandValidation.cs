using FKRM.Domain.Commands.Enrollment;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Enrollment
{
    public class CreateEnrollmentCommandValidation : EnrollmentValidation<CreateEnrollmentCommand>
    {
        public CreateEnrollmentCommandValidation()
        {
            ValidateName();
        }
    }
}
