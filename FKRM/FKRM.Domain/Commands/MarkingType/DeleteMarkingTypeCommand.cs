using FKRM.Domain.Validation.MarkingType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.MarkingType
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
