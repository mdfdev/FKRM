using FKRM.Application.Validation.Enrollment;

namespace FKRM.Application.Commands.Enrollment
{
    public class CreateEnrollmentCommand : EnrollmentCommand
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
