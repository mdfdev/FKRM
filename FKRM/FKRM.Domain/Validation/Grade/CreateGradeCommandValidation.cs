using FKRM.Domain.Commands.Grade;

namespace FKRM.Domain.Validation.Grade
{
    public class CreateGradeCommandValidation : GradeValidation<CreateGradeCommand>
    {
        public CreateGradeCommandValidation()
        {
            ValidateName();
        }
    }
}
