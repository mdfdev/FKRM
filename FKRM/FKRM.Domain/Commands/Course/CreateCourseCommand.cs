using FKRM.Domain.Commands.Gender;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Course
{
    public class CreateCourseCommand: CourseCommand
    {
        public CreateCourseCommand(string name)
        {
            Name = name;
        }
    }
}
