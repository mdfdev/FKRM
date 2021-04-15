using FKRM.Application.Validation.Gender;
using System;

namespace FKRM.Application.Commands.Gender
{
    public class UpdateGenderCommand : GenderCommand
    {
        public UpdateGenderCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateGenderCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
