
using FKRM.Application.Commands.AcademicDegree;

namespace FKRM.Application.Validation.AcademicDegree
{
    public class CreateAcademicDegreeCommandValidation : AcademicDegreeValidation<CreateAcademicDegreeCommand>
    {
        public CreateAcademicDegreeCommandValidation()
        {
            ValidateName();
        }
    }
}
