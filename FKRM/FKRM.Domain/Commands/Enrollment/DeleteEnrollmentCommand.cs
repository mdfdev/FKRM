using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Enrollment
{
    public class DeleteEnrollmentCommand : EnrollmentCommand
    {
        public DeleteEnrollmentCommand(Guid id)
        {
            ID = id;
        }
    }
}
