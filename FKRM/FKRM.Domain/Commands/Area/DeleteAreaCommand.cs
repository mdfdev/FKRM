using FKRM.Domain.Validation.Area;
using System;

namespace FKRM.Domain.Commands.Area
{
    public class DeleteAreaCommand : AreaCommand
    {
        public DeleteAreaCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteAreaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
