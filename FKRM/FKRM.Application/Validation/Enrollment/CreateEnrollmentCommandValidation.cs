using FKRM.Application.Commands.Enrollment;

namespace FKRM.Application.Validation.Enrollment
{
    public class CreateEnrollmentCommandValidation : EnrollmentValidation<CreateEnrollmentCommand>
    {
        public CreateEnrollmentCommandValidation()
        {
            ValidateName();
        }
    }
}
