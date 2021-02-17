using FKRM.Domain.Commands.Schedule;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Schedule
{
    public abstract class ScheduleValidation<T> : AbstractValidator<T> where T : ScheduleCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.StartTime)
                .GreaterThan(0).WithMessage("Name cannot be empty");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
