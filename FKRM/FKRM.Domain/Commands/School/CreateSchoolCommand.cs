using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.School
{
    public class CreateSchoolCommand: SchoolCommand
    {
        public CreateSchoolCommand(string name,string code)
        {
            Name = name;
            Code = code;
        }
    }
}
