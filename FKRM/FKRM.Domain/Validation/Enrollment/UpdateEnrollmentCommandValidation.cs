using FKRM.Domain.Commands.Enrollment;

namespace FKRM.Domain.Validation.Enrollment
{
    public class UpdateEnrollmentCommandValidation : EnrollmentValidation<UpdateEnrollmentCommand>
    {
        public UpdateEnrollmentCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
