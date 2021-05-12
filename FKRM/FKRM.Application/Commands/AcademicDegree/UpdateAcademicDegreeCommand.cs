using FKRM.Application.Validation.AcademicDegree;
using System;

namespace FKRM.Application.Commands.AcademicDegree
{
    public class UpdateAcademicDegreeCommand : AcademicDegreeCommand
    {
        public UpdateAcademicDegreeCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateAcademicDegreeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
