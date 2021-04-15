using FKRM.Application.Validation.Gender;
using System;

namespace FKRM.Application.Commands.Gender
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
