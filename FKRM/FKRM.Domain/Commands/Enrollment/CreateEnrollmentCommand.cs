using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Enrollment
{
    public class CreateEnrollmentCommand: EnrollmentCommand
    {
        public CreateEnrollmentCommand(string name)
        {
            Name = name;
        }
    }
}
