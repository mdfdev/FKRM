using FKRM.Domain.Commands.Schedule;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.Schedule
{
    public abstract class ScheduleValidation<T> : AbstractValidator<T> where T : ScheduleCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.StartTime)
                .GreaterThan(0).WithMessage("زمان شروع الزامی می باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
