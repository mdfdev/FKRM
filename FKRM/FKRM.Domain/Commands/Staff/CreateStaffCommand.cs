using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Staff
{
    public class CreateStaffCommand: StaffCommand
    {
        public CreateStaffCommand(string name)
        {
            Name = name;
        }
    }
}
