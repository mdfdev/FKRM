using FKRM.Application.Validation.Area;
using System;

namespace FKRM.Application.Commands.Area
{
    public class CreateAreaCommand : AreaCommand
    {
        public CreateAreaCommand(string name,Guid branchId)
        {
            Name = name;
            BranchId = branchId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateAreaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
