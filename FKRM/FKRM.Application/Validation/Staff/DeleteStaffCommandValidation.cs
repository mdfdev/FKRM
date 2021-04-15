using FKRM.Application.Commands.Staff;

namespace FKRM.Application.Validation.Staff
{
    public class DeleteStaffCommandValidation : StaffValidation<DeleteStaffCommand>
    {
        public DeleteStaffCommandValidation()
        {
            ValidateId();
        }
    }
}
