using FKRM.Application.Validation.Enrollment;
using System;

namespace FKRM.Application.Commands.Enrollment
{
    public class DeleteEnrollmentCommand : EnrollmentCommand
    {
        public DeleteEnrollmentCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteEnrollmentCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
