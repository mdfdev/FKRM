using FKRM.Application.Validation.Course;
using System;

namespace FKRM.Application.Commands.Course
{
    public class UpdateCourseCommand : CourseCommand
    {
        public UpdateCourseCommand(Guid id, string name, string code, int credits, int passMark, Guid majorId, Guid gradeId, Guid markingTypeId, int practicalWeeklyHours, int theoreticalWeeklyHours)
        {
            ID = id;
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
            ValidationResult = new UpdateCourseCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
