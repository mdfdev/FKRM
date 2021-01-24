using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Major
{
    public class UpdateMajorCommand : MajorCommand
    {
        public UpdateMajorCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
