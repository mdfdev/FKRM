using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.Grade;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Grade
{
    public class CreateGradeCommand: GradeCommand
    {
        public CreateGradeCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateGradeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
