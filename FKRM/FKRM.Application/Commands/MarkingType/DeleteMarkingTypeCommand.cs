using FKRM.Application.Validation.MarkingType;
using System;

namespace FKRM.Application.Commands.MarkingType
{
    public class DeleteMarkingTypeCommand : MarkingTypeCommand
    {
        public DeleteMarkingTypeCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteMarkingTypeCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
