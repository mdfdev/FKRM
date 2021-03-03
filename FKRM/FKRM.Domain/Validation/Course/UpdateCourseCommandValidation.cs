using FKRM.Domain.Commands.Course;

namespace FKRM.Domain.Validation.Course
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
