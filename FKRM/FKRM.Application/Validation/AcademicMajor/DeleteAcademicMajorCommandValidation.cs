using FKRM.Application.Commands.AcademicMajor;

namespace FKRM.Application.Validation.AcademicMajor
{
    public class DeleteAcademicMajorCommandValidation : AcademicMajorValidation<DeleteAcademicMajorCommand>
    {
        public DeleteAcademicMajorCommandValidation()
        {
            ValidateName();
        }
    }
}
