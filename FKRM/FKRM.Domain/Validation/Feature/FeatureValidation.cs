using FKRM.Domain.Commands.Feature;
using FluentValidation;
using System;

namespace FKRM.Domain.Validation.Feature
{
    public abstract class FeatureValidation<T> : AbstractValidator<T> where T : FeatureCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("نام ویژگی الزامی می باشد")
                .Length(2, 20).WithMessage("طول نام باید بین 2~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
