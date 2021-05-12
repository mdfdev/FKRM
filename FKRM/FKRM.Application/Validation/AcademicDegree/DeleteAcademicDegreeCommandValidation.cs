using FKRM.Application.Commands.AcademicDegree;

namespace FKRM.Application.Validation.AcademicDegree
{
    public class DeleteAcademicDegreeCommandValidation : AcademicDegreeValidation<DeleteAcademicDegreeCommand>
    {
        public DeleteAcademicDegreeCommandValidation()
        {
            ValidateName();
        }
    }
}
