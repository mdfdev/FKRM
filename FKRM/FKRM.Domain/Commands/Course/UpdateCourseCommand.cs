using FKRM.Domain.Validation.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Commands.Course
{
    public class UpdateCourseCommand : CourseCommand
    {
        public UpdateCourseCommand(Guid id,string name)
        {
            ID = id;
            Name = name;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateCourseCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
