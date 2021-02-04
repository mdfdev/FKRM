using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Staff
{
    public class CreateStaffCommand: StaffCommand
    {
        public CreateStaffCommand(string fname,string lname,string phone,string mobile,string nationalcode)
        {
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Mobile = mobile;
            NationalCode = nationalcode;
        }
    }
}
