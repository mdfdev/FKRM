using FKRM.Application.Validation.Staff;
using System;

namespace FKRM.Application.Commands.Staff
{
    public class UpdateStaffCommand : StaffCommand
    {
        public UpdateStaffCommand(Guid id, string fname, string lname, string phone, string mobile, string nationalcode, Guid jobtitleId)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Mobile = mobile;
            NationalCode = nationalcode;
            JobTitleId = jobtitleId;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateStaffCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
