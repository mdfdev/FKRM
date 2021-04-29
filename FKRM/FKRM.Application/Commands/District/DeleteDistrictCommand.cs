using FKRM.Application.Validation.District;
using System;

namespace FKRM.Application.Commands.District
{
    public class DeleteDistrictCommand : DistrictCommand
    {
        public DeleteDistrictCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteDistrictCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
