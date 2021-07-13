using FKRM.Application.Commands.Course;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.Course
{
    public abstract class CourseValidation<T> : AbstractValidator<T> where T : CourseCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("نام درس")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(3,20).WithMessage("طول {PropertyName} باید بین 3~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
        protected void ValidateCode()
        {
            RuleFor(c => c.Code)
                .NotEmpty()
                .NotNull()
                .WithName("کد درس")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(5).WithMessage("طول {PropertyName} 5 حرف می باشد.");
        }
        protected void ValidateCredits()
        {
            RuleFor(c => c.Credits)
                .NotEmpty()
                .WithName("تعداد واحد")
                .WithMessage("{PropertyName} الزامی می باشد")
                .GreaterThanOrEqualTo(1)
                .LessThanOrEqualTo(8)
                .WithMessage("{PropertyName} درس بین 1~6 می باشد");
        }
        protected void ValidatePassMark()
        {
            RuleFor(c => c.PassMark)
                .NotEmpty()
                .WithName("حد نصاب قبولی")
                .WithMessage("{PropertyName} الزامی می باشد")
                .GreaterThanOrEqualTo(10)
                .LessThanOrEqualTo(20)
                .WithMessage("{PropertyName} حداقل 10 می باشد.");
        }
    }
}
