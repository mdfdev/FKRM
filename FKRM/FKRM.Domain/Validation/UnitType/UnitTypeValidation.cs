using FKRM.Domain.Commands.UnitType;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.UnitType
{
    public abstract class UnitTypeValidation<T> : AbstractValidator<T> where T : UnitTypeCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("نام الزامی می باشد")
                .Length(3, 20).WithMessage("طول نام باید بین 3~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
