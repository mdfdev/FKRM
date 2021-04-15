using FKRM.Application.Validation.Major;
using System;

namespace FKRM.Application.Commands.Major
{
    public class DeleteMajorCommand : MajorCommand
    {
        public DeleteMajorCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteMajorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
