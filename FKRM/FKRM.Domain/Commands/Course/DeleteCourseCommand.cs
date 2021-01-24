using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Course
{
    public class DeleteCourseCommand : CourseCommand
    {
        public DeleteCourseCommand(Guid id)
        {
            ID = id;
        }
    }
}
