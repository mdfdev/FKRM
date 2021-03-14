using FKRM.Domain.Commands.Course;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.Course
{
    public abstract class CourseValidation<T> : AbstractValidator<T> where T : CourseCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("نام درس الزامی می باشد")
                .Length(3,20).WithMessage("طول نام درس باید بین 3~20 کاراکتر باشد");
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
                .WithMessage("کد درس الزامی می باشد.")
                .Length(5).WithMessage("طول کد درس 5 حرف می باشد.");
        }
        protected void ValidateCredits()
        {
            RuleFor(c => c.Credits)
                .NotEmpty()
                .WithMessage("کد درس الزامی می باشد.")
                .GreaterThanOrEqualTo(1)
                .LessThanOrEqualTo(8)
                .WithMessage("تعداد واحد درس بین 1~6 می باشد");
        }
        protected void ValidatePassMark()
        {
            RuleFor(c => c.PassMark)
                .NotEmpty()
                .WithMessage("کد درس الزامی می باشد.")
                .GreaterThanOrEqualTo(10)
                .LessThanOrEqualTo(20)
                .WithMessage("حد نصاب قبولی حداقل 10 می باشد.");
        }
    }
}
