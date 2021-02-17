using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.School;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.School
{
    public class CreateSchoolCommand: SchoolCommand
    {
        public CreateSchoolCommand(Guid id,string name)
        {
            Name = name;
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateSchoolCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
