using FKRM.Domain.Commands.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Course
{
    class UpdateCourseCommandValidation : CourseValidation<UpdateCourseCommand>
    {
        public UpdateCourseCommandValidation()
        {
            ValidateId();
            ValidateName();
        }
    }
}
