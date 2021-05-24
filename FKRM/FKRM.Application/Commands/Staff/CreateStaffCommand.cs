using FKRM.Application.Validation.Staff;
using System;

namespace FKRM.Application.Commands.Staff
{
    public class CreateStaffCommand : StaffCommand
    {
        public CreateStaffCommand(string fname, string lname, string phone, string mobile, string nationalcode,Guid jobtitleId,Guid schoolId,Guid academicCalendarId,
            string birthDate, string hiringDate, string email, string bio)
        {
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Mobile = mobile;
            NationalCode = nationalcode;
            JobTitleId = jobtitleId;
            SchoolId = schoolId;
            AcademicCalendarId = academicCalendarId;
            BirthDate = birthDate;
            HiringDate = hiringDate;
            Email = email;
            Bio = bio;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateStaffCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
