using FKRM.Application.Commands.Gender;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.Gender
{
    public abstract class GenderValidation<T> : AbstractValidator<T> where T : GenderCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("نام جنسیت")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(2, 10)
                .WithMessage("طول {PropertyName} باید بین 2~10 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
