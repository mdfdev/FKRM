using FKRM.Domain.Commands.Enrollment;

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
