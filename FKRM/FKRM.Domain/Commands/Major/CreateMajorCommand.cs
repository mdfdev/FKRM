using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Major
{
    public class CreateMajorCommand: MajorCommand
    {
        public CreateMajorCommand(string name)
        {
            Name = name;
        }
    }
}
