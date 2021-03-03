using FKRM.Domain.Commands.Staff;

namespace FKRM.Domain.Validation.Staff
{
    public class UpdateStaffCommandValidation : StaffValidation<UpdateStaffCommand>
    {
        public UpdateStaffCommandValidation()
        {
            ValidateId();
            ValidateFirstName();
            ValidateLastName();
        }
    }
}
