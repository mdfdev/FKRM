using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.Enrollment;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Enrollment
{
    public class CreateEnrollmentCommand: EnrollmentCommand
    {
        public CreateEnrollmentCommand(int capacity)
        {
            Capacity = capacity;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateEnrollmentCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
