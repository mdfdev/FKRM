using FKRM.Domain.Commands.Area;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.Area
{
    public abstract class AreaValidation<T> : AbstractValidator<T> where T : AreaCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("نام الزامی می باشد")
                .Length(3, 20)
                .WithMessage("طول نام باید بین 3~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
