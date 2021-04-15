using FKRM.Application.Validation.Staff;
using System;

namespace FKRM.Application.Commands.Staff
{
    public class CreateStaffCommand : StaffCommand
    {
        public CreateStaffCommand(string fname, string lname, string phone, string mobile, string nationalcode,Guid jobtitleId,Guid schoolId,Guid academicCalendarId)
        {
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Mobile = mobile;
            NationalCode = nationalcode;
            JobTitleId = jobtitleId;
            SchoolId = schoolId;
            AcademicCalendarId = academicCalendarId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateStaffCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
