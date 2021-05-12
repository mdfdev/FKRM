using FKRM.Application.Commands.AcademicMajor;

namespace FKRM.Application.Validation.AcademicMajor
{
    public class UpdateAcademicMajorCommandValidation : AcademicMajorValidation<UpdateAcademicMajorCommand>
    {
        public UpdateAcademicMajorCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
