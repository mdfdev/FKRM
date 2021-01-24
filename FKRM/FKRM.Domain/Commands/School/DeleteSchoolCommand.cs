using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.School
{
    public class DeleteSchoolCommand : SchoolCommand
    {
        public DeleteSchoolCommand(Guid id)
        {
            ID = id;
        }
    }
}
