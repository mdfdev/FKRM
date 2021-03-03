using FKRM.Domain.Validation.MarkingType;
using System;

namespace FKRM.Domain.Commands.MarkingType
{
    public class UpdateMarkingTypeCommand : MarkingTypeCommand
    {
        public UpdateMarkingTypeCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateMarkingTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
