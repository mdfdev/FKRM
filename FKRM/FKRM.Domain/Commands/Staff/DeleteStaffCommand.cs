using FKRM.Domain.Validation.Staff;
using System;
using System.Collections.Generic;
using System.Text;

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
