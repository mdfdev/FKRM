using FKRM.Domain.Validation.Staff;
using System;

namespace FKRM.Domain.Commands.Staff
{
    public class CreateStaffCommand : StaffCommand
    {
        public CreateStaffCommand(string fname, string lname, string phone, string mobile, string nationalcode,Guid jobtitleId)
        {
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Mobile = mobile;
            NationalCode = nationalcode;
            JobTitleId = jobtitleId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateStaffCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
