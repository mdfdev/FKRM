using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Grade
{
    public class DeleteGradeCommand : GradeCommand
    {
        public DeleteGradeCommand(Guid id)
        {
            ID = id;
        }
    }
}
