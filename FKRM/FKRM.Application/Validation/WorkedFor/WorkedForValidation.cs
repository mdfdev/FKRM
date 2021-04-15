using FKRM.Application.Commands.WorkedFor;
using FluentValidation;
using System;


namespace FKRM.Application.Validation.WorkedFor
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
