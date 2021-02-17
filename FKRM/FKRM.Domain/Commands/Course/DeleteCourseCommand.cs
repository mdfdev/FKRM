using FKRM.Domain.Validation.Course;
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
        public override bool IsValid()
        {
            ValidationResult = new DeleteCourseCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
