using FKRM.Domain.Validation.Course;
using System;

namespace FKRM.Domain.Commands.Course
{
    public class UpdateCourseCommand : CourseCommand
    {
        public UpdateCourseCommand(Guid id, string name)
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
