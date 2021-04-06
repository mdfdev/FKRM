using FKRM.Domain.Commands.WorkedFor;
using FluentValidation;
using System;


namespace FKRM.Domain.Validation.WorkedFor
{
    public class WorkedForValidation<T> : AbstractValidator<T> where T : WorkedForCommand
    {
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
