using FKRM.Application.Validation.AcademicMajor;
using System;

namespace FKRM.Application.Commands.AcademicMajor
{
    public class CreateAcademicMajorCommand : AcademicMajorCommand
    {
        public CreateAcademicMajorCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateAcademicMajorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
