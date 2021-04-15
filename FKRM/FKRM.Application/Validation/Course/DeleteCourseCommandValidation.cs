using FKRM.Application.Commands.Course;

namespace FKRM.Application.Validation.Course
{
    public class DeleteCourseCommandValidation : CourseValidation<DeleteCourseCommand>
    {
        public DeleteCourseCommandValidation()
        {
            ValidateId();
        }
    }
}
