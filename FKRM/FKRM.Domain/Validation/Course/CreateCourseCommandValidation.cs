using FKRM.Domain.Commands.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Course
{
    public class CreateCourseCommandValidation : CourseValidation<CreateCourseCommand>
    {
        public CreateCourseCommandValidation()
        {
            ValidateName();
        }
    }
}
