using FKRM.Application.Commands.Grade;

namespace FKRM.Application.Validation.Grade
{
    public class CreateGradeCommandValidation : GradeValidation<CreateGradeCommand>
    {
        public CreateGradeCommandValidation()
        {
            ValidateName();
        }
    }
}
