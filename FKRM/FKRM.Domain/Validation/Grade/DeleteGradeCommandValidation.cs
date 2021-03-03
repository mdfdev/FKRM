using FKRM.Domain.Commands.Grade;

namespace FKRM.Domain.Validation.Grade
{
    public class DeleteGradeCommandValidation : GradeValidation<DeleteGradeCommand>
    {
        public DeleteGradeCommandValidation()
        {
            ValidateId();
        }
    }
}
