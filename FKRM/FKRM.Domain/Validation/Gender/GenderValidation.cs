using FKRM.Domain.Commands.Gender;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.Gender
{
    public abstract class GenderValidation<T> : AbstractValidator<T> where T : GenderCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("نام الزامی می باشد")
                .Length(2, 10).WithMessage("طول نام باید بین 2~10 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
