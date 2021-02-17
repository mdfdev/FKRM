using FKRM.Domain.Commands.Enrollment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Validation.Enrollment
{
    public abstract class EnrollmentValidation<T> : AbstractValidator<T> where T : EnrollmentCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Capacity)
                .GreaterThan(0).WithMessage("Name cannot be empty");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
