using FKRM.Domain.Commands.MarkingType;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.MarkingType
{
    public abstract class MarkingTypeValidation<T> : AbstractValidator<T> where T : MarkingTypeCommand
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
