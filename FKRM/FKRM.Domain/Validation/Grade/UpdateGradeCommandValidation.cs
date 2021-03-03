using FKRM.Domain.Commands.Grade;

namespace FKRM.Domain.Validation.Grade
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
