using FKRM.Application.Validation.AcademicDegree;
using FKRM.Application.Validation.Area;
using System;

namespace FKRM.Application.Commands.AcademicDegree
{
    public class CreateAcademicDegreeCommand : AcademicDegreeCommand
    {
        public CreateAcademicDegreeCommand(string name)
        {
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateAcademicDegreeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
