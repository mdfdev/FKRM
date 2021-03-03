using FKRM.Domain.Commands.AcademicCalendar;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.AcademicCalendar
{
    public abstract class AcademicCalendarValidation<T> : AbstractValidator<T> where T : AcademicCalendarCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.AcademicYear)
                .NotEmpty().WithMessage("سال تحصیلی الزامی می باشد")
                .Length(3, 20).WithMessage("طول نام باید بین 3~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
