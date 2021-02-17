using FKRM.Domain.Validation.Major;
using System;
using System.Collections.Generic;
using System.Text;

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
