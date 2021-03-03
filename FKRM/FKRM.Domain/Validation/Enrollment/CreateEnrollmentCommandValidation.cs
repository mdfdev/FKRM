using FKRM.Domain.Commands.Enrollment;

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
