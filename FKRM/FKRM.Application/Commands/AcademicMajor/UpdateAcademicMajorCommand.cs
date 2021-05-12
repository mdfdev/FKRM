using FKRM.Application.Validation.AcademicMajor;
using System;

namespace FKRM.Application.Commands.AcademicMajor
{
    public class UpdateAcademicMajorCommand : AcademicMajorCommand
    {
        public UpdateAcademicMajorCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateAcademicMajorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
