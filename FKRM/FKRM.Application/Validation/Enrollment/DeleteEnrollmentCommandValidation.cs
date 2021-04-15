using FKRM.Application.Commands.Enrollment;

namespace FKRM.Application.Validation.Enrollment
{
    public class DeleteEnrollmentCommandValidation : EnrollmentValidation<DeleteEnrollmentCommand>
    {
        public DeleteEnrollmentCommandValidation()
        {
            ValidateId();
        }
    }
}
