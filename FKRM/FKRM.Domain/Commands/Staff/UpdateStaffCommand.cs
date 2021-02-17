using FKRM.Domain.Validation.Staff;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Staff
{
    public class UpdateStaffCommand:StaffCommand
    {
        public UpdateStaffCommand(Guid id, string fname, string lname, string phone, string mobile, string nationalcode)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Mobile = mobile;
            NationalCode = nationalcode;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateStaffCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
