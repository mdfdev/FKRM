using FKRM.Domain.Validation.Staff;

namespace FKRM.Domain.Commands.Staff
{
    public class CreateStaffCommand : StaffCommand
    {
        public CreateStaffCommand(string fname, string lname, string phone, string mobile, string nationalcode)
        {
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Mobile = mobile;
            NationalCode = nationalcode;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateStaffCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
