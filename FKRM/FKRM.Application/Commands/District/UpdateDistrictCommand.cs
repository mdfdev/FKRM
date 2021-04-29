using FKRM.Application.Validation.District;
using System;

namespace FKRM.Application.Commands.District
{
    public class UpdateDistrictCommand : DistrictCommand
    {
        public UpdateDistrictCommand(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateDistrictCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
