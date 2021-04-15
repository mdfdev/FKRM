using FKRM.Application.Commands.Grade;

namespace FKRM.Application.Validation.Grade
{
    public class DeleteGradeCommandValidation : GradeValidation<DeleteGradeCommand>
    {
        public DeleteGradeCommandValidation()
        {
            ValidateId();
        }
    }
}
