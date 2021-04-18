using FKRM.Application.Commands.Staff;

namespace FKRM.Application.Validation.Staff
{
    public class UpdateStaffCommandValidation : StaffValidation<UpdateStaffCommand>
    {
        public UpdateStaffCommandValidation()
        {
            ValidateId();
            ValidateFirstName();
            ValidateLastName();
            ValidateMobile();
            ValidateNationalID();
            ValidatePhone();
        }
    }
}
