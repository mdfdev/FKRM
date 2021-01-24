using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.School
{
    public class UpdateSchoolCommand:SchoolCommand
    {
        public UpdateSchoolCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
