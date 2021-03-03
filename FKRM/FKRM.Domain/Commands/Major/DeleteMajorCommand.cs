using FKRM.Domain.Validation.Major;
using System;

namespace FKRM.Domain.Commands.Major
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
