using FKRM.Domain.Validation.Area;
using System;

namespace FKRM.Domain.Commands.Area
{
    public class UpdateAreaCommand : AreaCommand
    {
        public UpdateAreaCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateAreaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
