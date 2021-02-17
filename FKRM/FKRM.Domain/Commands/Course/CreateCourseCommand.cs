using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Validation.Course;
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
        public override bool IsValid()
        {
            ValidationResult = new CreateCourseCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
