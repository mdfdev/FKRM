using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Grade
{
    public class UpdateGradeCommand : GradeCommand
    {
        public UpdateGradeCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
