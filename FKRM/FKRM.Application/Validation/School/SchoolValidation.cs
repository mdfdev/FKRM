using FKRM.Application.Commands.School;
using FluentValidation;
using System;

namespace FKRM.Application.Validation.School
{
    public abstract class SchoolValidation<T> : AbstractValidator<T> where T : SchoolCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithName("نام مدرسه")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(5, 100)
                .WithMessage("طول {PropertyName} باید بین 5~100 کاراکتر باشد");
        }
        protected void ValidateCode()
        {
            RuleFor(c => c.Code)
                .NotEmpty()
                .WithName("کد مدرسه")
                .WithMessage("{PropertyName} الزامی می باشد")
                .Length(8)
                .WithMessage("طول {PropertyName} باید 8 کاراکتر باشد");
        }
        protected void ValidateId()
        {
            RuleFor(c => c.ID)
                .NotEqual(Guid.Empty);
        }
    }
}
