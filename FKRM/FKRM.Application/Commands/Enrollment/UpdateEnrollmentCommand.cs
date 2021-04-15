using FKRM.Application.Validation.Enrollment;
using System;

namespace FKRM.Application.Commands.Enrollment
{
    public class UpdateEnrollmentCommand : EnrollmentCommand
    {
        public UpdateEnrollmentCommand(Guid id, int capacity)
        {
            ID = id;
            Capacity = capacity;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateEnrollmentCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
