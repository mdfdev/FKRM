using FKRM.Application.Validation.Grade;
using System;

namespace FKRM.Application.Commands.Grade
{
    public class UpdateGradeCommand : GradeCommand
    {
        public UpdateGradeCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateGradeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
