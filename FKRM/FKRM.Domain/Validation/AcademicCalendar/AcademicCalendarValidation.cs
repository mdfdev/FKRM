using FKRM.Domain.Commands.AcademicCalendar;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.AcademicCalendar
{
    public abstract class AcademicCalendarValidation<T> : AbstractValidator<T> where T : AcademicCalendarCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.AcademicYear)
                .NotEmpty().WithMessage("AcademicYear cannot be empty")
                .Length(2, 10).WithMessage("The name is between 2~10 characters");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
