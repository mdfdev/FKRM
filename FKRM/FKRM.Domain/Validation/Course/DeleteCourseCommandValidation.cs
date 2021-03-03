using FKRM.Domain.Commands.Course;

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
