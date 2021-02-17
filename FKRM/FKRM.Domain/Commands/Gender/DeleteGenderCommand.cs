using FKRM.Domain.Validation.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Gender
{
    public class DeleteGenderCommand : GenderCommand
    {
        public DeleteGenderCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteGenderCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
