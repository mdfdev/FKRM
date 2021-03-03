using FKRM.Domain.Commands.Staff;

namespace FKRM.Domain.Validation.Staff
{
    public class DeleteStaffCommandValidation : StaffValidation<DeleteStaffCommand>
    {
        public DeleteStaffCommandValidation()
        {
            ValidateId();
        }
    }
}
