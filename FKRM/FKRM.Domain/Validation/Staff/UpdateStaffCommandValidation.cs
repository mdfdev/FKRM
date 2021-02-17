using FKRM.Domain.Commands.Staff;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Staff
{
    public class UpdateStaffCommandValidation:StaffValidation<UpdateStaffCommand>
    {
        public UpdateStaffCommandValidation()
        {
            ValidateId();
            ValidateFirstName();
            ValidateLastName();
        }
    }
}
