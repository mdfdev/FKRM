using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Staff
{
    public class UpdateStaffCommand:StaffCommand
    {
        public UpdateStaffCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
