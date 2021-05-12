using FKRM.Application.Validation.AcademicMajor;
using System;

namespace FKRM.Application.Commands.AcademicMajor
{
    public class DeleteAcademicMajorCommand : AcademicMajorCommand
    {
        public DeleteAcademicMajorCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteAcademicMajorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
