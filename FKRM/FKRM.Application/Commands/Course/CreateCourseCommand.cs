using FKRM.Application.Validation.Course;
using System;

namespace FKRM.Application.Commands.Course
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name,string code,int credits,int passMark, Guid majorId, Guid gradeId, Guid markingTypeId, int practicalWeeklyHours , int theoreticalWeeklyHours)
        {
            Name = name;
            Code = code;
            Credits = credits;
            PassMark = passMark;
            MajorId = majorId;
            GradeId = gradeId;
            MarkingTypeId = markingTypeId;
            PracticalWeeklyHours = practicalWeeklyHours;
            TheoreticalWeeklyHours = theoreticalWeeklyHours;
        }
        public override bool IsValid()
        {
            ValidationResult = new CreateCourseCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
