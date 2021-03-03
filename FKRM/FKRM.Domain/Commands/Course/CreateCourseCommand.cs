using FKRM.Domain.Validation.Course;

namespace FKRM.Domain.Commands.Course
{
    public class CreateCourseCommand : CourseCommand
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
