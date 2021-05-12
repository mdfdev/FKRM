using FKRM.Application.Commands.AcademicDegree;

namespace FKRM.Application.Validation.AcademicDegree
{
    public class UpdateAcademicDegreeCommandValidation : AcademicDegreeValidation<UpdateAcademicDegreeCommand>
    {
        public UpdateAcademicDegreeCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
