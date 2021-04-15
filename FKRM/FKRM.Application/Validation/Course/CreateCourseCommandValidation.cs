using FKRM.Application.Commands.Course;

namespace FKRM.Application.Validation.Course
{
    public class CreateCourseCommandValidation : CourseValidation<CreateCourseCommand>
    {
        public CreateCourseCommandValidation()
        {
            ValidateName();
            ValidateCode();
            ValidateCredits();
            ValidatePassMark();
        }
    }
}
