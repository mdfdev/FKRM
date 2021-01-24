using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Enrollment
{
    public class UpdateEnrollmentCommand : EnrollmentCommand
    {
        public UpdateEnrollmentCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
