using FKRM.Domain.Validation.Course;
using System;

namespace FKRM.Domain.Commands.Course
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name,string code,int credits,int passMark, Guid majorId, Guid gradeId, Guid markingTypeId)
        {
            Name = name;
            Code = code;
            Credits = credits;
            PassMark = passMark;
            MajorId = majorId;
            GradeId = gradeId;
            MarkingTypeId = markingTypeId;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateCourseCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
