using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Staff
{
    public class DeleteStaffCommand : StaffCommand
    {
        public DeleteStaffCommand(Guid id)
        {
            ID = id;
        }
    }
}
