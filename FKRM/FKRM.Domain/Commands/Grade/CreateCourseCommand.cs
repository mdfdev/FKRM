using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Grade
{
    public class CreateGradeCommand: GradeCommand
    {
        public CreateGradeCommand(string name)
        {
            Name = name;
        }
    }
}
