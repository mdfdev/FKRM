using FKRM.Domain.Commands.Staff;

namespace FKRM.Domain.Validation.Staff
{
    public class CreateStaffCommandValidation : StaffValidation<CreateStaffCommand>
    {
        public CreateStaffCommandValidation()
        {
            ValidateFirstName();
            ValidateLastName();
        }
    }
}
