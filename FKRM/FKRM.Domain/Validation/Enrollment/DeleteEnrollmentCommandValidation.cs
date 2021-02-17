using FKRM.Domain.Commands.Enrollment;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Enrollment
{
    public class DeleteEnrollmentCommandValidation : EnrollmentValidation<DeleteEnrollmentCommand>
    {
        public DeleteEnrollmentCommandValidation()
        {
            ValidateId();
        }
    }
}
