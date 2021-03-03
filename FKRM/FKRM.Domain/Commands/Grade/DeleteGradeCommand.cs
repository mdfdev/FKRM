using FKRM.Domain.Validation.Grade;
using System;

namespace FKRM.Domain.Commands.Grade
{
    public class DeleteGradeCommand : GradeCommand
    {
        public DeleteGradeCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteGradeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
