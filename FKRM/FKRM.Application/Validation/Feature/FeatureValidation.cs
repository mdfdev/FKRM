using FKRM.Application.Commands.Feature;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.Feature
{
    public abstract class FeatureValidation<T> : AbstractValidator<T> where T : FeatureCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("نام ویژگی")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(2, 20)
                .WithMessage("طول {PropertyName} باید بین 2~20 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
