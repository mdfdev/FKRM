using FKRM.Application.Commands.OUType;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.OUType
{
    public abstract class OUTypeValidation<T> : AbstractValidator<T> where T : OUTypeCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("نام الزامی می باشد").Length(3, 20).WithMessage("طول نام باید بین 3~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
