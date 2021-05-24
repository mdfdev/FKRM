using FKRM.Application.Validation.Staff;
using System;

namespace FKRM.Application.Commands.Staff
{
    public class UpdateStaffCommand : StaffCommand
    {
        public UpdateStaffCommand(Guid id, string fname, string lname, string phone, string mobile, string nationalcode, Guid jobtitleId,
            string birthDate, string hiringDate, string email, string bio)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Mobile = mobile;
            NationalCode = nationalcode;
            JobTitleId = jobtitleId;
            BirthDate = birthDate;
            HiringDate = hiringDate;
            Email = email;
            Bio = bio;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateStaffCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
