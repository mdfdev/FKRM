using FKRM.Application.Commands.AcademicCalendar;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.AcademicCalendar
{
    public abstract class AcademicCalendarValidation<T> : AbstractValidator<T> where T : AcademicCalendarCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.AcademicYear)
                .NotEmpty()
                .WithName("نام شاخه")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(3, 20)
                .WithMessage("طول {PropertyName} باید بین 3~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
