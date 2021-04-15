using FKRM.Application.Commands.Grade;

namespace FKRM.Application.Validation.Grade
{
    public class UpdateGradeCommandValidation : GradeValidation<UpdateGradeCommand>
    {
        public UpdateGradeCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
