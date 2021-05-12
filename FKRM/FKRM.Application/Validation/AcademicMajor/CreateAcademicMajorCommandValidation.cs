
using FKRM.Application.Commands.AcademicMajor;

namespace FKRM.Application.Validation.AcademicMajor
{
    public class CreateAcademicMajorCommandValidation : AcademicMajorValidation<CreateAcademicMajorCommand>
    {
        public CreateAcademicMajorCommandValidation()
        {
            ValidateName();
        }
    }
}
