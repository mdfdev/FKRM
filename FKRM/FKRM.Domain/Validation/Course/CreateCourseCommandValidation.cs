using FKRM.Domain.Commands.Course;

namespace FKRM.Domain.Validation.Course
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
