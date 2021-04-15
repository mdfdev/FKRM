using FKRM.Application.Commands.Enrollment;

namespace FKRM.Application.Validation.Enrollment
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
