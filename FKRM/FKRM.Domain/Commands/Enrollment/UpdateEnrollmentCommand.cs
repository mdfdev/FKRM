using FKRM.Domain.Validation.Enrollment;
using System;

namespace FKRM.Domain.Commands.Enrollment
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
