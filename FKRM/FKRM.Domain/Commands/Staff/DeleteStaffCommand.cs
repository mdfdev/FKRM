using FKRM.Domain.Validation.Staff;
using System;

namespace FKRM.Domain.Commands.Staff
{
    public class DeleteStaffCommand : StaffCommand
    {
        public DeleteStaffCommand(Guid id)
        {
            ID = id;
        }
        public override bool IsValid()
        {
            ValidationResult = new DeleteStaffCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
