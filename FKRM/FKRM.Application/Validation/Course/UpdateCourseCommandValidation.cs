using FKRM.Application.Commands.Course;

namespace FKRM.Application.Validation.Course
{
    class UpdateCourseCommandValidation : CourseValidation<UpdateCourseCommand>
    {
        public UpdateCourseCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateCode();
            ValidateCredits();
            ValidatePassMark();
        }
    }
}
