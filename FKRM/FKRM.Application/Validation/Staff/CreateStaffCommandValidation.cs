using FKRM.Application.Commands.Staff;

namespace FKRM.Application.Validation.Staff
{
    public class CreateStaffCommandValidation : StaffValidation<CreateStaffCommand>
    {
        public CreateStaffCommandValidation()
        {
            ValidateFirstName();
            ValidateLastName();
            ValidateMobile();
            ValidateNationalID();
            ValidatePhone();
            ValidateBirthDate();
            ValidateHiringDate();
        }
    }
}
