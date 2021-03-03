using FKRM.Domain.Commands.Enrollment;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.Enrollment
{
    public abstract class EnrollmentValidation<T> : AbstractValidator<T> where T : EnrollmentCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Capacity)
                .GreaterThan(0).WithMessage("ظرفیت الزامی می باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
