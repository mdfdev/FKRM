using FKRM.Domain.Commands.Course;
using FKRM.Domain.Validation.Area;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Course
{
    public class DeleteCourseCommandValidation : CourseValidation<DeleteCourseCommand>
    {
        public DeleteCourseCommandValidation()
        {
            ValidateId();
        }
    }
}
