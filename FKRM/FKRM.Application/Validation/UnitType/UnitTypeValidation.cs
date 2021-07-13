using FKRM.Application.Commands.UnitType;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.UnitType
{
    public abstract class UnitTypeValidation<T> : AbstractValidator<T> where T : UnitTypeCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("نام شاخه")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(3, 20).WithMessage("طول {PropertyName} باید بین 3~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
